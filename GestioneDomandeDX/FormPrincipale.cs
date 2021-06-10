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

namespace GestioneDomandeDX
{
    
    public partial class FormPrincipale : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /*






            OBBIETTIVI ATTUALI
            -GESTIRE IL SALVATAGGIO
                +CONTROLLARE SE I DATI SALVATI RISPETTANO LE REGOLE
                +COLORARE LE RIGHE MODIFICATE  FATTO
                +USARE  System.ComponentModel.DataAnnotations PER I REQUISITI
                +USARE CLASSE ValidationAttribute PER I CONTROLLI PRECENDENTI
            -DECIDERE SULLA MODALITà DI CARICAMENTO FATTO
            -GESTIRE IL TESTO IN TEDESCO E FRANCESE
                !VIENE AGGIUNTO UN CARATTERE IN PIù IN MEZZO AGLI ALTRI
            -Combobox per alcuni flag






        */
        GridView dettagli;
        egafEntities context;
        List<int> HandleCambiatiMaster;
        List<int> HandleCambiatiDetail;
        List<int> RisposteFlaggate;
        List<BarItem> itemMenu;
        Dictionary<string, int> DictTC;
        public FormPrincipale()
        {
            #region Inizializzazione
            InitializeComponent();
            context = new egafEntities();
            HandleCambiatiMaster = new List<int>();
            HandleCambiatiDetail = new List<int>();
            itemMenu = new List<BarItem>();
            RisposteFlaggate = new List<int>();
            DictTC = context.v_tipipatente.ToDictionary(tc =>tc.MD_DESCRIZIONE,tc=>tc.TC_ID);
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
                    itemMenu.Add(new BarButtonItem(barm, coppia.Key));
                }
            }
            
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
            int rispFalse = 0;        
            //controllo se le risposte rispettano le regole
            //calcolo sbagliato, re ris x dom - re limite risp false è quello giusto
            if(re.Risposte_libere == 0)
            {
                rispFalse = (int)re.RE_RISXDOM - 1;
                foreach (risposte e in d.risposte)
                {
                    if (e.RI_VF == "F")
                    {
                        rispFalse--;
                    }
                }
                if (rispFalse != 0)
                    return false;
                return true;
            }
            else
            {
                rispFalse = 0;
                foreach (risposte e in d.risposte)
                {
                    if (e.RI_VF == "F")
                    {
                        rispFalse++;
                    }
                }
                return rispFalse >= re.RE_LIMITE_MIN_RISPFALSE && rispFalse <= re.RE_LIMITE_RISPFALSE;
            }
            
            //se si daro vero
            //se no darò falso
        }
        private void clickSubMenu(object sender, ItemClickEventArgs e)
        {
            try
            {
                //IMAGE INDEX INDICA IL TC_ID
                int idNuovo = e.Item.ImageIndex;
                HandleCambiatiMaster.Clear();
                HandleCambiatiDetail.Clear();
                grdMain.DataSource = new BindingList<domande>(context.tipocommissione.Where(tc => tc.TC_ID == idNuovo).First().domande.ToList());
            }
            catch
            {
                MessageBox.Show("Vuoto");
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

        private void gridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            //Controllo se rispetta le regole
        }

        

        private void gridView_MasterRowCollapsed(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            
        }


        private void gridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            context.SaveChanges();
            //dovrei creare un gridview.RowStyle event in cui l'aggiorno
            //è un dettaglio?
            if (((GridView)sender).IsDetailView)
            {
                HandleCambiatiDetail.Add(e.RowHandle);
                if (!valida(((risposte)((GridView)sender).GetRow(e.RowHandle)).domande))
                {
                    RisposteFlaggate.Add(e.RowHandle);
                    MessageBox.Show("Invalida");
                }else if (RisposteFlaggate.Contains(e.RowHandle))
                {
                    RisposteFlaggate.Remove(e.RowHandle);
                }
            }
            else
            {
                HandleCambiatiMaster.Add(e.RowHandle);
            }
            ((GridView)sender).RefreshRow(e.RowHandle);
            

        }
        private void grdMain_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            dettagli = (GridView)e.View;
            //dettagli.Name = gridView
            dettagli.RowUpdated += new RowObjectEventHandler(gridView_RowUpdated);
            dettagli.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
            dettagli.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;
        }

        private void grdMain_ViewRemoved(object sender, ViewOperationEventArgs e)
        {
            ((GridView)e.View).RowUpdated -= new RowObjectEventHandler(gridView_RowUpdated);
            ((GridView)e.View).RowStyle -= new RowStyleEventHandler(gridView_RowStyle);
        }

        private void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (((GridView)sender).IsDetailView)
            {
                if (HandleCambiatiDetail.Contains(e.RowHandle))
                {
                    e.Appearance.BackColor = Color.Yellow;
                    if (RisposteFlaggate.Contains(e.RowHandle))
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
    }
}
