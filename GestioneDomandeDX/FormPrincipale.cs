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
        IDictionary<string, int> DictTC;
        public FormPrincipale()
        {
            InitializeComponent();
            context = new egafEntities();
            //DictTC = context.tipocommissione.Select(t => new { t.TC_DESCRIZIONE, t.TC_ID }).ToArray().ToDictionary(x => x.TC_DESCRIZIONE, x => x.TC_ID);
            DictTC = context.v_tipipatente.Select(tp => new { tp.MD_DESCRIZIONE, tp.TC_ID }).ToDictionary(x => x.MD_DESCRIZIONE, x => x.TC_ID);
            listaPatenti.Strings.AddRange(DictTC.Keys.ToArray());
            HandleCambiatiMaster = new List<int>();
            HandleCambiatiDetail = new List<int>();
            itemMenu = new List<BarItem>();
            //----Inizializzo il BarManager
            BarManager barm = new BarManager();
            barm.Form = this;
            barm.BeginUpdate();
            //----Qua devo creare una serie di bottoni per ogni TC senza subpatente. per quelli che ce l'hanno faccio un submenu
            //controllo se la patente ha subpatenti
            BarSubItem submenu = new BarSubItem(barm, "test", new BarItem[] { new BarButtonItem(barm,"test2"), new BarButtonItem(barm,"test3") });
            foreach(KeyValuePair<string,int> coppia in DictTC)
            {
                //if(Query returns more than 1 exam)
                //get the exams
                //create a BarSubItem for them
                int tc_id = coppia.Value;
                if(context.v_tipipatente.Where(v=>v.TC_ID == tc_id).Select(v=> v.QTA).Any(c=>c>1))
                {
                    //Dovrei trovare gli esami ed aggiungerli
                }
                else
                {
                    //creo un nuovo bottone con nome = coppia.Key
                    itemMenu.Add(new BarButtonItem(barm, coppia.Key));
                }
            }
            
            menuPatenti.AddItem(submenu);
            menuPatenti.AddItems(itemMenu.ToArray());
            barm.ItemClick += clickSubMenu;
            //menuPatenti.AddItems();
            gridView.DataController.AllowIEnumerableDetails = true;

        }

        private void clickSubMenu(object sender, ItemClickEventArgs e)
        {
            if (e.Link.OwnerItem.Name == "")
            {
                MessageBox.Show("submenuitem");
            }
        }

        private void FormPrincipale_Load(object sender, EventArgs e)
        {

        }

        private void btnScegliMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //Qua devo scegliere l'esame in base alla commissione. Una volta scelto dovro cercare tutte le domande e risposte

            int idNuovo = DictTC[listaPatenti.Caption];
            grdMain.DataSource = new BindingList<domande>(context.tipocommissione.Select(tc => tc).Where(tc => tc.TC_ID == idNuovo).First().domande.ToList());

        }

        private void listaPatenti_ItemClick(object sender, DevExpress.XtraBars.ListItemClickEventArgs e)
        {

            listaPatenti.Caption = ((BarListItem)sender).Strings[((BarListItem)sender).ItemIndex];


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

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            context.SaveChanges();
            
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
            dettagli.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(gridView_RowUpdated);
            dettagli.RowStyle += new RowStyleEventHandler(gridView_RowStyle);
        }

        private void grdMain_ViewRemoved(object sender, ViewOperationEventArgs e)
        {
            ((GridView)e.View).RowUpdated -= new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(gridView_RowUpdated);
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
    }
}
