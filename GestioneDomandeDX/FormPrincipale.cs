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
        List<BarItem> itemMenu;
        Dictionary<string, int> DictTC;
        public FormPrincipale()
        {
            InitializeComponent();
            context = new egafEntities();
            HandleCambiatiMaster = new List<int>();
            HandleCambiatiDetail = new List<int>();
            itemMenu = new List<BarItem>();
            DictTC = context.v_tipipatente.ToDictionary(tc =>tc.MD_DESCRIZIONE,tc=>tc.TC_ID);
            //----Inizializzo il BarManager
            BarManager barm = new BarManager();
            barm.Form = this;
            barm.BeginUpdate();
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

        private void clickSubMenu(object sender, ItemClickEventArgs e)
        {
            //IMAGE INDEX INDICA IL TC_ID
            int idNuovo = e.Item.ImageIndex;
            grdMain.DataSource = new BindingList<domande>(context.tipocommissione.Where(tc => tc.TC_ID == idNuovo).First().domande.ToList());
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }
        private void btnSceltaIniziale_ItemClick(object sender, ItemClickEventArgs e)
        {

            var iniziali = ((string)txtIniziale.EditValue).Split(',').AsEnumerable();

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
