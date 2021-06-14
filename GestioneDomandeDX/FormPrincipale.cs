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

namespace GestioneDomandeDX
{

    public partial class FormPrincipale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /*






            OBBIETTIVI ATTUALI
            ---------------------------------------------------------------------------------
                                                 IMPORTANTE
            ---------------------------------------------------------------------------------
            -RISTRUTTURARE IL CODICE PER ADATTARLO ALLA LISTA DI GRIGLIE
            ---------------------------------------------------------------------------------
                                                 IMPORTANTE
            ---------------------------------------------------------------------------------
            -GESTIRE IL SALVATAGGIO FATTO
                +CONTROLLARE SE I DATI SALVATI RISPETTANO LE REGOLE FATTO
                +COLORARE LE RIGHE MODIFICATE  FATTO
                +USARE  System.ComponentModel.DataAnnotations PER I REQUISITI 
            -DECIDERE SULLA MODALITà DI CARICAMENTO FATTO
            -GESTIRE IL TESTO IN TEDESCO E FRANCESE
                !VIENE AGGIUNTO UN CARATTERE IN PIù IN MEZZO AGLI ALTRI
            -Combobox per alcuni flag 1/2
            -cambiare form modifica
            -lock e gestione crash FATTO
            -aggiunta domande e risposte GESTITO DALLA GRIGLIA
            --pulsante per entrare e lockare, uscire e unlockare FATTO
            -!se non sei in modifca, grid readonly FATTO
            -applicare modifiche in certi campi anche in quelli con codice egaf uguali
            -rendere la domanda non modificabile quando il testo risposta contiene il testo della domanda
            -Organizzare in funzioni parti di codice ripetuta


        */
        GridView dettagli;
        egafEntities context;
        lockUtils lck;
        List<int> HandleCambiatiMaster;
        List<Tuple<int, int>> HandleCambiatiDetail;
        List<Tuple<int,int>> RisposteFlaggate;
        List<BarItem> itemMenu;
        // forse avro bisogno di un List<GridView> per tutte le viste presenti. Servirà per applicare un singolo cambiamento a tutte
        List<GridView> listaDettagli;
        bool TABEDITABILI;
        RepositoryItemMemoEdit memoEdit;

        public FormPrincipale()
        {
            #region Inizializzazione
            InitializeComponent();
            context = new egafEntities();
            HandleCambiatiMaster = new List<int>();
            HandleCambiatiDetail = new List<Tuple<int,int>>();
            itemMenu = new List<BarItem>();
            RisposteFlaggate = new List<Tuple<int, int>>();
            memoEdit = new RepositoryItemMemoEdit();
            memoEdit.WordWrap = true;
            //LockUtils
            lck = new lockUtils(context);
            listaDettagli = new List<GridView>();
            if (context.locks.Any(l => l.USER == Environment.UserName))
                lck.unLock();
            Dictionary<string, int> DictTC = context.v_tipipatente.ToDictionary(tc =>tc.MD_DESCRIZIONE,tc=>tc.TC_ID);
            TABEDITABILI = false;
            gridView.OptionsBehavior.Editable = TABEDITABILI;
            btnLascia.Enabled = false;
            btnLock.Enabled = true;
            //----Inizializzo il BarManager
            BarManager barm = new BarManager();
            barm.Form = this;            
            barm.BeginUpdate();
            
            #endregion
            #region aggiunta Patenti al menu patenti
            //----Qua devo creare una serie di bottoni per ogni TC senza subpatente. per quelli che ce l'hanno faccio un submenu
            //controllo se la patente ha subpatenti
            foreach (KeyValuePair<string,int> coppia in DictTC)
            {
                //if(Query returns more than 1 exam)
                //get the exams
                //create a BarSubItem for them
                int tc_id = coppia.Value;
                if(context.v_tipipatente.Where(v=>v.TC_ID == tc_id).Select(v=> v.QTA).Any(c=>c>1))
                {
                    //Dovrei trovare gli esami ed aggiungerli
                    var listaEsami = context.esami.Where(e => e.ES_TC_ID == tc_id).Select(e=> new { e.ES_TC_ID,e.ES_ID,e.ES_DESCRIZIONE,e.ES_RE_ID,e.ES_REVISIONE,e.ES_NONSELEZIONABILE}).ToList();
                    List<BarButtonItem> bottoniEsame = new List<BarButtonItem>();
                    foreach(var es in listaEsami)
                    {
                        bottoniEsame.Add(new BarButtonItem(barm, es.ES_DESCRIZIONE,tc_id));
                    }
                    string nome = coppia.Key;
                    itemMenu.Add(new BarSubItem(barm,nome,bottoniEsame.ToArray()));
                }
                else
                {
                    //creo un nuovo bottone con nome = coppia.Key
                    itemMenu.Add(new BarButtonItem(barm, coppia.Key,tc_id));
                }
            }
            //context.releaseopere.Select(ro => ro.)
            menuPatenti.AddItems(itemMenu.ToArray());
            barm.ItemClick += clickSubMenu;
            barm.EndUpdate();
            #endregion
            gridView.DataController.AllowIEnumerableDetails = true;

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
                HandleCambiatiMaster.Clear();
                HandleCambiatiDetail.Clear();
                context = new egafEntities();
                grdMain.DataSource = new BindingList<domande>(context.tipocommissione.Where(tc => tc.TC_ID == idNuovo).First().domande.ToList());
                gridView.Columns["DO_TESTO"].ColumnEdit = memoEdit;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }
        private void btnSceltaIniziale_ItemClick(object sender, ItemClickEventArgs e)
        {

            var iniziali = ((string)txtIniziale.EditValue).Split(',').AsEnumerable();
            HandleCambiatiMaster.Clear();
            HandleCambiatiDetail.Clear();
            
            grdMain.DataSource = context.domande.Where(d => iniziali.Any(i => d.DO_CODICE_MINST.StartsWith(i))).ToList();
            gridView.Columns["DO_TESTO"].ColumnEdit = memoEdit;
        }
        private void onClickCmb(object sender, EventArgs e)
        {
            int flagBlock = ((ComboBoxEdit)sender).SelectedIndex;

            GridView main = (GridView)((GridControl)((ComboBoxEdit)sender).Parent).MainView;
            var domanda = (main.GetFocusedRow() as domande);
            int d = domanda.DO_ID;
            ((BindingList<domande>)grdMain.DataSource).Where(dom => dom.DO_ID == d).Select(dom => dom.DO_FLAG_BLOCCATA = flagBlock);
        }
        #region Gestione Master-Detail
        private void gridView_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            domande d = (domande)gridView.GetRow(e.RowHandle);
            e.ChildList = d.risposte.ToList();
        }

        private void gridView_AfterPrintRow(object sender, DevExpress.XtraGrid.Views.Printing.PrintRowEventArgs e)
        {
            gridView.ExpandMasterRow(e.RowHandle);
        }
       
        private void gridView_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            domande d = (domande)gridView.GetRow(e.RowHandle);
            e.IsEmpty = d.risposte.Count == 0;
        }

        private void gridView_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "risposte";
        }

        private void gridView_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 1;
        }
        #endregion
        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {}
        private void gridView_MasterRowCollapsed(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e){}
        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            context.SaveChanges();
            //dovrei creare un gridview.RowStyle event in cui l'aggiorno
            //è un dettaglio?
            GridView griglia = sender as GridView;
            if (griglia.IsDetailView)
            {
                HandleCambiatiDetail.Add(new Tuple<int, int>(griglia.SourceRowHandle,e.RowHandle));
                if (!valida(((risposte)griglia.GetRow(e.RowHandle)).domande))
                {
                    
                    RisposteFlaggate.Add(new Tuple<int, int>(griglia.SourceRowHandle, e.RowHandle));
                    MessageBox.Show("Invalida");
                }else if (RisposteFlaggate.Contains(new Tuple<int, int>(griglia.SourceRowHandle, e.RowHandle)))
                {
                    RisposteFlaggate.Remove(new Tuple<int, int>(griglia.SourceRowHandle,e.RowHandle));
                }
            }
            else
            {
                HandleCambiatiMaster.Add(e.RowHandle);
            }
            griglia.RefreshRow(e.RowHandle);
            

        }
        private void grdMain_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            dettagli = (GridView)e.View;
            listaDettagli.Add(dettagli);
            dettagli.RowUpdated += new RowObjectEventHandler(gridView_RowUpdated);
            dettagli.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            dettagli.Columns["RI_TESTO"].ColumnEdit = memoEdit;
            dettagli.OptionsBehavior.Editable = TABEDITABILI;

        }
        private void grdMain_ViewRemoved(object sender, ViewOperationEventArgs e)
        {
            ((GridView)e.View).RowUpdated -= new RowObjectEventHandler(gridView_RowUpdated);
            ((GridView)e.View).RowStyle -= new RowStyleEventHandler(gridView_RowStyle);
            listaDettagli.Remove(((GridView)e.View));
        }
        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView griglia = sender as GridView;
            if (griglia.IsDetailView)
            {
                if (HandleCambiatiDetail.Contains(new Tuple<int, int>(griglia.SourceRowHandle,e.RowHandle)))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    if (RisposteFlaggate.Contains(new Tuple<int,int>(griglia.SourceRowHandle, e.RowHandle)))
                    {
                        e.Appearance.BackColor = Color.Red;
                    }
                }
                
            }
            else
            {
                if (HandleCambiatiMaster.Contains(e.RowHandle))
                {
                    e.Appearance.BackColor = Color.Yellow;
                }
            }
            
        }
        private void FormPrincipale_SizeChanged(object sender, EventArgs e)
        {
            
        }
        private void btnSalvaLayout_Click(object sender, EventArgs e)
        {
            gridView.OptionsLayout.Columns.StoreAllOptions = true;
            gridView.SaveLayoutToXml(@"..\..\layout.xml");
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnLock.Enabled = false;
            btnLascia.Enabled = true;
            if (lck.IsLocked())
            {
                MessageBox.Show("La tabella è Lockata. Aspettare");
                TABEDITABILI = false;
                return;
            }
            //unlocko la griglia
            unlockGriglia();

        }
        void lockGriglia()
        {
            lck.unLock();
            TABEDITABILI = false;
            gridView.OptionsBehavior.Editable = false;
            listaDettagli.Select(d => d.OptionsBehavior.Editable = false);
        }
        void unlockGriglia()
        {
            lck.lockTables();
            TABEDITABILI = true;
            gridView.OptionsBehavior.Editable = true;
            listaDettagli.Select(d => d.OptionsBehavior.Editable = true);
        }

        private void btnLascia_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (lck.IsLocked())
            {
                lockGriglia();
                lck.unLock();
            }
            btnLock.Enabled = true;
            btnLascia.Enabled = false;
            return;
        }
    }
    public class lockUtils
    {
        egafEntities ctx;
        public lockUtils(egafEntities con)
        {
            this.ctx = con;
        }
        public bool IsLocked()
        {
            
            return ctx.locks.Count() > 0;
        }
        public void lockTables()
        {
            locks newLock = new locks();
            newLock.DATAORA = DateTime.Now;
            newLock.USER = Environment.UserName;
            ctx.locks.Add(newLock);
            ctx.SaveChanges();
        }
        public void unLock()
        {
            ctx.Database.ExecuteSqlCommand("TRUNCATE TABLE locks");
        }
    }
}
