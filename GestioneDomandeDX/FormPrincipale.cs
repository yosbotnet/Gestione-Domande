
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Entity;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;

namespace GestioneDomandeDX
{

    public partial class FormPrincipale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /*


            OBBIETTIVI ATTUALI
            ---------------------------------------------------------------------------------
                                       GIOVEDI E VENERDI 17/6
            ---------------------------------------------------------------------------------
            -aggiunta domande e risposte 
            -rendere la domanda non modificabile quando il testo risposta contiene il testo
            della domanda 
            ---------------------------------------------------------------------------------
                                      OBIETTIVI GIORNALIERI
            ---------------------------------------------------------------------------------
            -GESTIRE IL SALVATAGGIO FATTO
                +CONTROLLARE SE I DATI SALVATI RISPETTANO LE REGOLE FATTO
                +COLORARE LE RIGHE MODIFICATE  FATTO
            -DECIDERE SULLA MODALITà DI CARICAMENTO FATTO
            -GESTIRE IL TESTO IN TEDESCO E FRANCESE
                !VIENE AGGIUNTO UN CARATTERE IN PIù IN MEZZO AGLI ALTRI       
            -applicare modifiche in certi campi anche in quelli con codice egaf uguali
            
        */

        egafEntities context;
        lockUtils lck;
        List<int> HandleCambiatiMaster;
        List<Tuple<int, int>> RisposteFlaggate;
        List<BarItem> itemMenu;
        // forse avro bisogno di un List<GridView> per tutte le viste presenti. Servirà per applicare un singolo cambiamento a tutte
        List<GridView> listaDettagli;
        bool TABEDITABILI;
        bool DOM_NO_TESTO;
        RepositoryItemMemoEdit memoEdit;
        string[] colonneMerge = { "DO_ID", "DO_CODICE_EGAF", "DO_CODICE_MINST", "DO_TESTO", "DO_TESTOFR","DO_TESTODE" };
        public FormPrincipale()
        {
            #region Inizializzazione
            InitializeComponent();
            context = new egafEntities();
            HandleCambiatiMaster = new List<int>();
            itemMenu = new List<BarItem>();
            RisposteFlaggate = new List<Tuple<int, int>>();
            memoEdit = new RepositoryItemMemoEdit();
            memoEdit.WordWrap = true;
            //LockUtils
            lck = new lockUtils(context);
            listaDettagli = new List<GridView>();
            if (context.locks.Any(l => l.USER == Environment.UserName))
                lck.unLock();
            Dictionary<string, int> DictTC = context.v_tipipatente.ToDictionary(tc => tc.MD_DESCRIZIONE, tc => tc.TC_ID);
            TABEDITABILI = false;

            gridView.OptionsBehavior.Editable = TABEDITABILI;
            //----Inizializzo il BarManager
            BarManager barm = new BarManager();
            barm.Form = this;
            barm.BeginUpdate();

            #endregion
            #region aggiunta Patenti al menu patenti
            //----Qua devo creare una serie di bottoni per ogni TC senza subpatente. per quelli che ce l'hanno faccio un submenu
            //controllo se la patente ha subpatenti
            foreach (KeyValuePair<string, int> coppia in DictTC)
            {
                //if(Query returns more than 1 exam)
                //get the exams
                //create a BarSubItem for them
                int tc_id = coppia.Value;
                if (context.v_tipipatente.Where(v => v.TC_ID == tc_id).Select(v => v.QTA).Any(c => c > 1))
                {
                    //Dovrei trovare gli esami ed aggiungerli
                    var listaEsami = context.esami.Where(e => e.ES_TC_ID == tc_id).Select(e => new { e.ES_TC_ID, e.ES_ID, e.ES_DESCRIZIONE, e.ES_RE_ID, e.ES_REVISIONE, e.ES_NONSELEZIONABILE }).ToList();
                    List<BarButtonItem> bottoniEsame = new List<BarButtonItem>();
                    foreach (var es in listaEsami)
                    {
                        bottoniEsame.Add(new BarButtonItem(barm, es.ES_DESCRIZIONE, tc_id));
                    }
                    string nome = coppia.Key;
                    itemMenu.Add(new BarSubItem(barm, nome, bottoniEsame.ToArray()));
                }
                else
                {
                    //creo un nuovo bottone con nome = coppia.Key
                    itemMenu.Add(new BarButtonItem(barm, coppia.Key, tc_id));
                }
            }
            //context.releaseopere.Select(ro => ro.)
            menuPatenti.AddItems(itemMenu.ToArray());
            barm.ItemClick += clickSubMenu;
            barm.EndUpdate();
            #endregion
            btnLock.Enabled = false;
            btnLascia.Enabled = false;

            gridView.DataController.AllowIEnumerableDetails = true;
            gridView.OptionsView.AllowCellMerge = true;
            foreach (GridColumn c in gridView.Columns)
            {
                if (!colonneMerge.Contains(c.FieldName))
                {
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
                else
                {
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
            }
        }

        private bool valida(domande d)
        {
            //data una domanda
            //ottengo le regole, ottenibili da es_re_id. es_re_id è ottenibile da ES_ID
            int? reID = context.esami.Where(e => e.ES_ID == d.DO_ES_ID).Select(e => e.ES_RE_ID).First();
            v_regole re = context.v_regole.Where(vr => vr.RE_ID == reID).First();
            int rispFalse = d.risposte.Where(r => r.RI_VF == "F").Count();
            int rispVere = d.risposte.Where(r => r.RI_VF == "V").Count();

            //controllo se le risposte rispettano le regole
            if (re.Risposte_libere == 0)
            {
                //re ris x dom == totale risposte
                return rispVere == 1 && rispFalse == re.RE_RISXDOM - 1;
            }
            else
            {
                return rispVere >= re.RE_LIMITE_MIN_RISPFALSE - re.RE_LIMITE_RISPFALSE;

            }
        }
        private void clickSubMenu(object sender, ItemClickEventArgs e)
        {
            try
            {
                //IMAGE INDEX INDICA IL TC_ID
                int idNuovo = e.Item.ImageIndex;
                int idEsame = context.v_esami.Where(ve => ve.ES_TC_ID == idNuovo).OrderBy(r => r.ES_REVISIONE).First().ES_ID;
                setupGrid(context.v_domerisp.Where(dr => dr.DO_ES_ID == idEsame).ToList());
                gridView.Columns["RI_TESTO"].ColumnEdit = memoEdit;
                gridView.Columns["RI_TESTOFR"].ColumnEdit = memoEdit;
                gridView.Columns["RI_TESTODE"].ColumnEdit = memoEdit;
                gridView.Columns["DO_TESTO_AIUTO"].ColumnEdit = memoEdit;
                gridView.OptionsView.RowAutoHeight = true;
                gridView.Columns["DO_ID"].OptionsColumn.AllowEdit = false;
                gridView.Columns["RI_ID"].OptionsColumn.AllowEdit = false;
                if (context.v_releaseopere.Where(ro => ro.RO_TC_ID == idNuovo).FirstOrDefault().RO_TESTORISPOSTA_CONTIENE_TESTODOMANDA == 1)
                {
                    DOM_NO_TESTO = true;
                    gridView.Columns["DO_TESTO"].OptionsColumn.AllowEdit = false;
                }
                else
                {
                    DOM_NO_TESTO = false;
                    gridView.Columns["DO_TESTO"].OptionsColumn.AllowEdit = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnSceltaIniziale_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                var iniziali = ((string)txtIniziale.EditValue).Split(',').AsEnumerable();
                //Si va in readonly
                setupGrid(context.v_domerisp.Where(d => iniziali.Any(i => d.DO_CODICE_MINST.StartsWith(i))).ToList());
                TABEDITABILI = false;
                gridView.OptionsBehavior.Editable = TABEDITABILI;
                listaDettagli.ForEach(d => d.OptionsBehavior.Editable = TABEDITABILI);
                btnLock.Enabled = false;
                btnLascia.Enabled = false;
                DOM_NO_TESTO = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void onClickCmb(object sender, EventArgs e)
        {
            int flagBlock = ((ComboBoxEdit)sender).SelectedIndex;

            GridView main = (GridView)((GridControl)((ComboBoxEdit)sender).Parent).MainView;
            var domanda = (main.GetFocusedRow() as domande);
            int d = domanda.DO_ID;
            ((BindingList<domande>)grdMain.DataSource).Where(dom => dom.DO_ID == d).Select(dom => dom.DO_FLAG_BLOCCATA = flagBlock);
        }
        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            var d = (e.Row as v_domerisp_proxy);
            var vd = context.v_domerisp.Where(dr => dr.RI_ID == d.RI_ID).First();
            if (!d.Equals(vd))
            {
                if (d.DO_TESTO == vd.DO_TESTO)
                {
                    HandleCambiatiMaster.Add(e.RowHandle);
                    context.SaveChanges();
                    GridView griglia = sender as GridView;
                    griglia.RefreshRow(e.RowHandle);

                }
                else
                {
                    GridView griglia = sender as GridView;
                    var gvi = griglia.GetViewInfo() as GridViewInfo;
                    var gci = gvi.GetGridCellInfo(e.RowHandle, griglia.Columns["DO_TESTO"]);
                    if (gci.MergedCell != null)
                    {
                        gci.MergedCell.MergedCells.ForEach(c => HandleCambiatiMaster.Add(c.RowHandle));
                    }
                }


            }





        }
        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView griglia = sender as GridView;
            if (HandleCambiatiMaster.Contains(e.RowHandle))
            {
                e.Appearance.BackColor = Color.Yellow;
            }
        }


        private void FormPrincipale_SizeChanged(object sender, EventArgs e) { }

        private void btnSalvaLayout_Click(object sender, EventArgs e)
        {
            gridView.OptionsLayout.Columns.StoreAllOptions = true;
            gridView.SaveLayoutToXml(@"..\..\layout.xml");
        }

        private void expandVisibleRows()
        {
            GridViewInfo viewInfo = gridView.GetViewInfo() as GridViewInfo;
            int visibleRows = viewInfo.RowsInfo.Count;
            int firstRow = gridView.TopRowIndex;
            for (int i = firstRow; i < firstRow + visibleRows; i++)
            {
                if (!gridView.GetMasterRowExpanded(i))
                    gridView.SetMasterRowExpanded(i, true);
            }
        }
        private void btnPrendi_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (lck.IsLocked())
            {
                MessageBox.Show("La tabella è Lockata Da " + string.Join(", ", lck.LockOwners()));
                TABEDITABILI = false;
                return;
            }
            //unlocko la griglia
            unlockGriglia();

        }
        private void btnLascia_ItemClick(object sender, ItemClickEventArgs e)
        {
            lockGriglia();
            lck.unLock();
            return;
        }
        void lockGriglia()
        {
            btnLock.Enabled = true;
            btnLascia.Enabled = false;
            lck.unLock();
            TABEDITABILI = false;
            gridView.OptionsBehavior.Editable = false;
            listaDettagli.ForEach(d => d.OptionsBehavior.Editable = false);
        }
        void unlockGriglia()
        {

            if (lck.lockTables())
            {
                btnLock.Enabled = false;
                btnLascia.Enabled = true;
                TABEDITABILI = true;
                gridView.OptionsBehavior.Editable = true;
                listaDettagli.ForEach(d => d.OptionsBehavior.Editable = true); ;
            }

        }
        //esempio di riga
        // '5', 'Ame', '2007-05-08 12:35:29'
        private void setupGrid(List<v_domerisp> query)
        {
            HandleCambiatiMaster.Clear();
            context = new egafEntities();
            lck = new lockUtils(context);
            //codice questionabile
            lck.unLock();
            btnLock.Enabled = true;
            btnLascia.Enabled = false;
            grdMain.DataSource = new BindingList<v_domerisp_proxy>(query.Select(q => new v_domerisp_proxy(q, context)).ToList());
            gridView.Columns["DO_TESTO"].ColumnEdit = memoEdit;
            foreach (GridColumn c in gridView.Columns)
            {
                if (!colonneMerge.Contains(c.FieldName))
                {
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                }
                else
                {
                    c.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
                }
            }
        }

        private void FormPrincipale_FormClosing(object sender, FormClosingEventArgs e)
        {
            lck.unLock();
        }


        private void gridView_CellMerge(object sender, CellMergeEventArgs e)
        {
            if ((e.CellValue1 != null && e.CellValue2 != null) && e.CellValue1.Equals(e.CellValue2) && colonneMerge.Contains(e.Column.FieldName))
            {
                e.Handled = true;
                e.Merge = true;
            }
            else
            {
                e.Handled = true;
                e.Merge = false;
            }
        }

        private void gridView_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            /*
            MemoEdit tmpmemoEdit = new MemoEdit();
            for (int i = 0; i < gridView.RowCount; i++)
            {

                List<int> list = Enumerable.Range(0, gridView.RowCount).ToList();
                if (list.Contains(e.RowHandle))
                {
                    int totalHeight = 0;
                    foreach (int rowHandle in list)
                    {
                        string text = this.gridView.GetRowCellDisplayText(rowHandle, "DO_TESTO");
                        tmpmemoEdit.EditValue = text;
                        totalHeight += tmpmemoEdit.CalcAutoHeight();
                    }
                    tmpmemoEdit.EditValue = this.gridView.GetRowCellDisplayText(e.RowHandle, "RI_TESTO");
                    int rowHeight = tmpmemoEdit.CalcAutoHeight();
                    if (rowHeight < totalHeight)
                    {
                        tmpmemoEdit.EditValue = this.gridView.GetRowCellDisplayText(e.RowHandle, "DO_TESTO");
                        e.RowHeight = tmpmemoEdit.CalcAutoHeight();
                    }
                    else
                    {
                        e.RowHeight = rowHeight;
                    }
                }
            
            */
        }

        private void btnAddDomanda_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }
    /// <summary>
    /// Classe che gestisce i lock
    /// </summary>
    public class lockUtils
    {
        egafEntities ctx;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="con">contesto</param>
        public lockUtils(egafEntities con)
        {
            this.ctx = con;
        }
        public bool IsLocked()
        {
            return ctx.locks.Where(l => l.USER != Environment.UserName).Any();
        }
        public bool lockTables()
        {
            if (IsLocked())
            {
                //forse servira
                return false;
            }
            else
            {
                locks newLock = new locks();
                newLock.DATAORA = DateTime.Now;
                newLock.USER = Environment.UserName;
                ctx.locks.Add(newLock);
                ctx.SaveChanges();
                return true;
            }

        }
        public string[] LockOwners()
        {
            return ctx.locks.Select(l => l.USER).ToArray();
        }
        public void unLock()
        {
            ctx.Database.ExecuteSqlCommand(String.Format("DELETE FROM locks WHERE ID>=0 AND USER ='{0}'", Environment.UserName.Replace("'", "''")));
        }
    }
}
