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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            DevExpress.XtraSpellChecker.SpellCheckerDictionary spellCheckerDictionary1 = new DevExpress.XtraSpellChecker.SpellCheckerDictionary();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grdMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_TESTOORDINE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_TESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_TESTODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_TESTOFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_VF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_IMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_IMG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_FLAG_BLOCCATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_FLAG_BLOCCATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_ALTROTESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTO_AIUTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_IMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_IMG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_ALTROTESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_MULTIMEDIALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_ES_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_ES_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_CODICE_MINST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_CODICE_EGAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_GRDOMCORR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRI_ORDINAMENTOCASUALE = new DevExpress.XtraGrid.Columns.GridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
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
            this.gridView,
            this.gridView1});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDO_ID,
            this.colRI_ID,
            this.colDO_TESTO,
            this.colRI_TESTOORDINE,
            this.colDO_TESTODE,
            this.colDO_TESTOFR,
            this.colRI_TESTO,
            this.colRI_TESTODE,
            this.colRI_TESTOFR,
            this.colRI_VF,
            this.colDO_IMG,
            this.colDO_IMG2,
            this.colDO_FLAG_BLOCCATA,
            this.colDO_NOTE,
            this.colRI_FLAG_BLOCCATA,
            this.colRI_NOTE,
            this.colDO_ALTROTESTO,
            this.colDO_TESTO_AIUTO,
            this.colRI_IMG,
            this.colRI_IMG2,
            this.colRI_ALTROTESTO,
            this.colDO_MULTIMEDIALE,
            this.colDO_ES_ID,
            this.colRI_ES_ID,
            this.colDO_CODICE_MINST,
            this.colDO_CODICE_EGAF,
            this.colDO_GRDOMCORR,
            this.colRI_ORDINAMENTOCASUALE});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "regolaCambiamento";
            formatConditionRuleExpression1.PredefinedName = "Red Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.GridControl = this.grdMain;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.AllowCellMerge = true;
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowChildrenInGroupPanel = true;
            // 
            // colDO_ID
            // 
            this.colDO_ID.FieldName = "DO_ID";
            this.colDO_ID.Name = "colDO_ID";
            this.colDO_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDO_ID.Visible = true;
            this.colDO_ID.VisibleIndex = 0;
            this.colDO_ID.Width = 67;
            // 
            // colRI_ID
            // 
            this.colRI_ID.FieldName = "RI_ID";
            this.colRI_ID.Name = "colRI_ID";
            this.colRI_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_ID.Visible = true;
            this.colRI_ID.VisibleIndex = 1;
            this.colRI_ID.Width = 67;
            // 
            // colDO_TESTO
            // 
            this.colDO_TESTO.FieldName = "DO_TESTO";
            this.colDO_TESTO.Name = "colDO_TESTO";
            this.colDO_TESTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDO_TESTO.Visible = true;
            this.colDO_TESTO.VisibleIndex = 2;
            this.colDO_TESTO.Width = 304;
            // 
            // colRI_TESTOORDINE
            // 
            this.colRI_TESTOORDINE.FieldName = "RI_TESTOORDINE";
            this.colRI_TESTOORDINE.Name = "colRI_TESTOORDINE";
            this.colRI_TESTOORDINE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_TESTOORDINE.Visible = true;
            this.colRI_TESTOORDINE.VisibleIndex = 3;
            this.colRI_TESTOORDINE.Width = 57;
            // 
            // colDO_TESTODE
            // 
            this.colDO_TESTODE.FieldName = "DO_TESTODE";
            this.colDO_TESTODE.Name = "colDO_TESTODE";
            this.colDO_TESTODE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_TESTODE.Visible = true;
            this.colDO_TESTODE.VisibleIndex = 4;
            this.colDO_TESTODE.Width = 57;
            // 
            // colDO_TESTOFR
            // 
            this.colDO_TESTOFR.FieldName = "DO_TESTOFR";
            this.colDO_TESTOFR.Name = "colDO_TESTOFR";
            this.colDO_TESTOFR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_TESTOFR.Visible = true;
            this.colDO_TESTOFR.VisibleIndex = 5;
            this.colDO_TESTOFR.Width = 57;
            // 
            // colRI_TESTO
            // 
            this.colRI_TESTO.FieldName = "RI_TESTO";
            this.colRI_TESTO.Name = "colRI_TESTO";
            this.colRI_TESTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_TESTO.Visible = true;
            this.colRI_TESTO.VisibleIndex = 6;
            this.colRI_TESTO.Width = 332;
            // 
            // colRI_TESTODE
            // 
            this.colRI_TESTODE.FieldName = "RI_TESTODE";
            this.colRI_TESTODE.Name = "colRI_TESTODE";
            this.colRI_TESTODE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_TESTODE.Visible = true;
            this.colRI_TESTODE.VisibleIndex = 7;
            this.colRI_TESTODE.Width = 42;
            // 
            // colRI_TESTOFR
            // 
            this.colRI_TESTOFR.FieldName = "RI_TESTOFR";
            this.colRI_TESTOFR.Name = "colRI_TESTOFR";
            this.colRI_TESTOFR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_TESTOFR.Visible = true;
            this.colRI_TESTOFR.VisibleIndex = 8;
            this.colRI_TESTOFR.Width = 42;
            // 
            // colRI_VF
            // 
            this.colRI_VF.FieldName = "RI_VF";
            this.colRI_VF.Name = "colRI_VF";
            this.colRI_VF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_VF.Visible = true;
            this.colRI_VF.VisibleIndex = 9;
            this.colRI_VF.Width = 42;
            // 
            // colDO_IMG
            // 
            this.colDO_IMG.FieldName = "DO_IMG";
            this.colDO_IMG.Name = "colDO_IMG";
            this.colDO_IMG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_IMG.Visible = true;
            this.colDO_IMG.VisibleIndex = 10;
            this.colDO_IMG.Width = 42;
            // 
            // colDO_IMG2
            // 
            this.colDO_IMG2.FieldName = "DO_IMG2";
            this.colDO_IMG2.Name = "colDO_IMG2";
            this.colDO_IMG2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_IMG2.Visible = true;
            this.colDO_IMG2.VisibleIndex = 11;
            this.colDO_IMG2.Width = 42;
            // 
            // colDO_FLAG_BLOCCATA
            // 
            this.colDO_FLAG_BLOCCATA.FieldName = "DO_FLAG_BLOCCATA";
            this.colDO_FLAG_BLOCCATA.Name = "colDO_FLAG_BLOCCATA";
            this.colDO_FLAG_BLOCCATA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_FLAG_BLOCCATA.Visible = true;
            this.colDO_FLAG_BLOCCATA.VisibleIndex = 12;
            this.colDO_FLAG_BLOCCATA.Width = 42;
            // 
            // colDO_NOTE
            // 
            this.colDO_NOTE.FieldName = "DO_NOTE";
            this.colDO_NOTE.Name = "colDO_NOTE";
            this.colDO_NOTE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_NOTE.Visible = true;
            this.colDO_NOTE.VisibleIndex = 13;
            this.colDO_NOTE.Width = 42;
            // 
            // colRI_FLAG_BLOCCATA
            // 
            this.colRI_FLAG_BLOCCATA.FieldName = "RI_FLAG_BLOCCATA";
            this.colRI_FLAG_BLOCCATA.Name = "colRI_FLAG_BLOCCATA";
            this.colRI_FLAG_BLOCCATA.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_FLAG_BLOCCATA.Visible = true;
            this.colRI_FLAG_BLOCCATA.VisibleIndex = 14;
            this.colRI_FLAG_BLOCCATA.Width = 42;
            // 
            // colRI_NOTE
            // 
            this.colRI_NOTE.FieldName = "RI_NOTE";
            this.colRI_NOTE.Name = "colRI_NOTE";
            this.colRI_NOTE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_NOTE.Visible = true;
            this.colRI_NOTE.VisibleIndex = 15;
            this.colRI_NOTE.Width = 42;
            // 
            // colDO_ALTROTESTO
            // 
            this.colDO_ALTROTESTO.FieldName = "DO_ALTROTESTO";
            this.colDO_ALTROTESTO.Name = "colDO_ALTROTESTO";
            this.colDO_ALTROTESTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_ALTROTESTO.Visible = true;
            this.colDO_ALTROTESTO.VisibleIndex = 16;
            this.colDO_ALTROTESTO.Width = 42;
            // 
            // colDO_TESTO_AIUTO
            // 
            this.colDO_TESTO_AIUTO.FieldName = "DO_TESTO_AIUTO";
            this.colDO_TESTO_AIUTO.Name = "colDO_TESTO_AIUTO";
            this.colDO_TESTO_AIUTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_TESTO_AIUTO.Visible = true;
            this.colDO_TESTO_AIUTO.VisibleIndex = 17;
            this.colDO_TESTO_AIUTO.Width = 42;
            // 
            // colRI_IMG
            // 
            this.colRI_IMG.FieldName = "RI_IMG";
            this.colRI_IMG.Name = "colRI_IMG";
            this.colRI_IMG.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_IMG.Visible = true;
            this.colRI_IMG.VisibleIndex = 18;
            this.colRI_IMG.Width = 42;
            // 
            // colRI_IMG2
            // 
            this.colRI_IMG2.FieldName = "RI_IMG2";
            this.colRI_IMG2.Name = "colRI_IMG2";
            this.colRI_IMG2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_IMG2.Visible = true;
            this.colRI_IMG2.VisibleIndex = 19;
            this.colRI_IMG2.Width = 42;
            // 
            // colRI_ALTROTESTO
            // 
            this.colRI_ALTROTESTO.FieldName = "RI_ALTROTESTO";
            this.colRI_ALTROTESTO.Name = "colRI_ALTROTESTO";
            this.colRI_ALTROTESTO.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_ALTROTESTO.Visible = true;
            this.colRI_ALTROTESTO.VisibleIndex = 20;
            this.colRI_ALTROTESTO.Width = 42;
            // 
            // colDO_MULTIMEDIALE
            // 
            this.colDO_MULTIMEDIALE.FieldName = "DO_MULTIMEDIALE";
            this.colDO_MULTIMEDIALE.Name = "colDO_MULTIMEDIALE";
            this.colDO_MULTIMEDIALE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDO_MULTIMEDIALE.Visible = true;
            this.colDO_MULTIMEDIALE.VisibleIndex = 21;
            this.colDO_MULTIMEDIALE.Width = 42;
            // 
            // colDO_ES_ID
            // 
            this.colDO_ES_ID.FieldName = "DO_ES_ID";
            this.colDO_ES_ID.Name = "colDO_ES_ID";
            this.colDO_ES_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_ES_ID.Visible = true;
            this.colDO_ES_ID.VisibleIndex = 22;
            this.colDO_ES_ID.Width = 42;
            // 
            // colRI_ES_ID
            // 
            this.colRI_ES_ID.FieldName = "RI_ES_ID";
            this.colRI_ES_ID.Name = "colRI_ES_ID";
            this.colRI_ES_ID.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_ES_ID.Visible = true;
            this.colRI_ES_ID.VisibleIndex = 23;
            this.colRI_ES_ID.Width = 42;
            // 
            // colDO_CODICE_MINST
            // 
            this.colDO_CODICE_MINST.FieldName = "DO_CODICE_MINST";
            this.colDO_CODICE_MINST.Name = "colDO_CODICE_MINST";
            this.colDO_CODICE_MINST.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDO_CODICE_MINST.Visible = true;
            this.colDO_CODICE_MINST.VisibleIndex = 24;
            this.colDO_CODICE_MINST.Width = 42;
            // 
            // colDO_CODICE_EGAF
            // 
            this.colDO_CODICE_EGAF.FieldName = "DO_CODICE_EGAF";
            this.colDO_CODICE_EGAF.Name = "colDO_CODICE_EGAF";
            this.colDO_CODICE_EGAF.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colDO_CODICE_EGAF.Visible = true;
            this.colDO_CODICE_EGAF.VisibleIndex = 25;
            this.colDO_CODICE_EGAF.Width = 42;
            // 
            // colDO_GRDOMCORR
            // 
            this.colDO_GRDOMCORR.FieldName = "DO_GRDOMCORR";
            this.colDO_GRDOMCORR.Name = "colDO_GRDOMCORR";
            this.colDO_GRDOMCORR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colDO_GRDOMCORR.Visible = true;
            this.colDO_GRDOMCORR.VisibleIndex = 26;
            this.colDO_GRDOMCORR.Width = 42;
            // 
            // colRI_ORDINAMENTOCASUALE
            // 
            this.colRI_ORDINAMENTOCASUALE.FieldName = "RI_ORDINAMENTOCASUALE";
            this.colRI_ORDINAMENTOCASUALE.Name = "colRI_ORDINAMENTOCASUALE";
            this.colRI_ORDINAMENTOCASUALE.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colRI_ORDINAMENTOCASUALE.Visible = true;
            this.colRI_ORDINAMENTOCASUALE.VisibleIndex = 27;
            this.colRI_ORDINAMENTOCASUALE.Width = 97;
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
            this.btnSalvaLayout.Location = new System.Drawing.Point(1275, 104);
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
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
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
        private GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_TESTOORDINE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOFR;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_TESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_TESTODE;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_TESTOFR;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_VF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_IMG;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_IMG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_FLAG_BLOCCATA;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_FLAG_BLOCCATA;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ALTROTESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTO_AIUTO;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_IMG;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_IMG2;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_ALTROTESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_MULTIMEDIALE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ES_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_ES_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_CODICE_MINST;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_CODICE_EGAF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_GRDOMCORR;
        private DevExpress.XtraGrid.Columns.GridColumn colRI_ORDINAMENTOCASUALE;
    }
}

