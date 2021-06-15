using DevExpress.Utils.MVVM;
using DevExpress.XtraGrid.Views.Grid;

namespace GestioneDomandeDX
{
    partial class FormPrincipale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSpellChecker.SpellCheckerDictionary spellCheckerDictionary1 = new DevExpress.XtraSpellChecker.SpellCheckerDictionary();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grdMain = new DevExpress.XtraGrid.GridControl();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuScelta = new DevExpress.XtraBars.BarSubItem();
            this.txtIniziale = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSceltaIniziale = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.menuPatenti = new DevExpress.XtraBars.BarSubItem();
            this.btnLock = new DevExpress.XtraBars.BarButtonItem();
            this.btnLascia = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grpSceltaViaIniziale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSalvaLayout = new System.Windows.Forms.Button();
            this.controlloOrtografico = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.bandDomand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBand1
            // 
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = -1;
            // 
            // grdMain
            // 
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.Location = new System.Drawing.Point(0, 158);
            this.grdMain.MainView = this.gridView;
            this.grdMain.MenuManager = this.ribbon;
            this.grdMain.Name = "grdMain";
            this.grdMain.Size = new System.Drawing.Size(1370, 445);
            this.grdMain.TabIndex = 1;
            this.grdMain.UseEmbeddedNavigator = true;
            this.grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView});
            this.grdMain.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRegistered);
            this.grdMain.ViewRemoved += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRemoved);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.menuScelta,
            this.txtIniziale,
            this.btnSceltaIniziale,
            this.barListItem1,
            this.menuPatenti,
            this.btnLock,
            this.btnLascia});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.Size = new System.Drawing.Size(1370, 158);
            // 
            // menuScelta
            // 
            this.menuScelta.Caption = "Scegli Esame";
            this.menuScelta.Id = 1;
            this.menuScelta.Name = "menuScelta";
            // 
            // txtIniziale
            // 
            this.txtIniziale.Caption = "Iniziali separate da virgole:";
            this.txtIniziale.Edit = this.repositoryItemTextEdit1;
            this.txtIniziale.Id = 3;
            this.txtIniziale.Name = "txtIniziale";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // btnSceltaIniziale
            // 
            this.btnSceltaIniziale.Caption = "Seleziona";
            this.btnSceltaIniziale.Id = 4;
            this.btnSceltaIniziale.Name = "btnSceltaIniziale";
            this.btnSceltaIniziale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSceltaIniziale_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 5;
            this.barListItem1.Name = "barListItem1";
            // 
            // menuPatenti
            // 
            this.menuPatenti.Caption = "Lista Patente";
            this.menuPatenti.Id = 7;
            this.menuPatenti.Name = "menuPatenti";
            // 
            // btnLock
            // 
            this.btnLock.Caption = "Prendi Controllo";
            this.btnLock.Enabled = false;
            this.btnLock.Id = 8;
            this.btnLock.Name = "btnLock";
            this.btnLock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPrendi_ItemClick);
            // 
            // btnLascia
            // 
            this.btnLascia.Caption = "Lascia il Controllo";
            this.btnLascia.Id = 9;
            this.btnLascia.Name = "btnLascia";
            this.btnLascia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLascia_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.grpSceltaViaIniziale,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Scelta Esame";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.menuPatenti);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Scelta via menu";
            // 
            // grpSceltaViaIniziale
            // 
            this.grpSceltaViaIniziale.AllowTextClipping = false;
            this.grpSceltaViaIniziale.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.grpSceltaViaIniziale.ItemLinks.Add(this.txtIniziale);
            this.grpSceltaViaIniziale.ItemLinks.Add(this.btnSceltaIniziale);
            this.grpSceltaViaIniziale.Name = "grpSceltaViaIniziale";
            this.grpSceltaViaIniziale.Text = "Scelta Via Iniziale";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLock);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLascia);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Lock";
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            // 
            // btnSalvaLayout
            // 
            this.btnSalvaLayout.Location = new System.Drawing.Point(1287, 60);
            this.btnSalvaLayout.Name = "btnSalvaLayout";
            this.btnSalvaLayout.Size = new System.Drawing.Size(83, 24);
            this.btnSalvaLayout.TabIndex = 3;
            this.btnSalvaLayout.Text = "Salva Layout";
            this.btnSalvaLayout.UseVisualStyleBackColor = true;
            this.btnSalvaLayout.Click += new System.EventHandler(this.btnSalvaLayout_Click);
            // 
            // controlloOrtografico
            // 
            this.controlloOrtografico.Culture = new System.Globalization.CultureInfo("it-IT");
            spellCheckerDictionary1.AlphabetPath = "";
            spellCheckerDictionary1.CacheKey = null;
            spellCheckerDictionary1.Culture = new System.Globalization.CultureInfo("it-IT");
            spellCheckerDictionary1.DictionaryPath = "C:\\Users\\stagista\\Documents\\Visual Studio 2015\\Projects\\GestioneDomandeDX\\Medico." +
    "IT_20111218.oxt";
            spellCheckerDictionary1.Encoding = System.Text.Encoding.GetEncoding(1252);
            this.controlloOrtografico.Dictionaries.Add(spellCheckerDictionary1);
            this.controlloOrtografico.ParentContainer = null;
            this.controlloOrtografico.SpellCheckMode = DevExpress.XtraSpellChecker.SpellCheckMode.AsYouType;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            // 
            // gridView
            // 
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.bandDomand});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "regolaCambiamento";
            formatConditionRuleExpression1.PredefinedName = "Red Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.GridControl = this.grdMain;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.ShowChildrenInGroupPanel = true;
            // 
            // bandDomand
            // 
            this.bandDomand.Caption = "Domanda";
            this.bandDomand.Name = "bandDomand";
            this.bandDomand.VisibleIndex = 0;
            this.bandDomand.Width = 60;
            // 
            // FormPrincipale
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 603);
            this.Controls.Add(this.btnSalvaLayout);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.ribbon);
            this.Name = "FormPrincipale";
            this.Ribbon = this.ribbon;
            this.Text = "Gestione Domande";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipale_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrincipale_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarSubItem menuScelta;
        private DevExpress.XtraGrid.GridControl grdMain;
        private DevExpress.XtraBars.BarEditItem txtIniziale;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem btnSceltaIniziale;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup grpSceltaViaIniziale;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarSubItem menuPatenti;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.Button btnSalvaLayout;
        private DevExpress.XtraSpellChecker.SpellChecker controlloOrtografico;
        private DevExpress.XtraBars.BarButtonItem btnLock;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnLascia;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandGridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private MVVMContext mvvmContext;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand bandDomand;
    }
}

