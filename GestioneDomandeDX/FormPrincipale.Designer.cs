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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuScelta = new DevExpress.XtraBars.BarSubItem();
            this.txtIniziale = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSceltaIniziale = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.menuPatenti = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grpSceltaViaIniziale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSalvaLayout = new System.Windows.Forms.Button();
            this.controlloOrtografico = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.colDO_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_MINIST_MA_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_IMG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_AR_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_CODICE_MINST = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_CODICE_EGAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_IMG2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_MULTIMEDIALE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_STATISTICA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_COMMENTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_FLAG_BLOCCATA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_NOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_FLAG_BLOCCATA_EGAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_NOTE_EGAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TEORICOPRATICO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_ES_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_FLAG_OBSOLETA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOCN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTODE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOGB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTOFR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTORU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_PROGRESSIVO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_STATISTICAV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_STATISTICAF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_GRDOMCORR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_ALTROTESTO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDO_TESTO_AIUTO = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdMain;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableDetailToolTip = true;
            this.gridView1.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
            // 
            // grdMain
            // 
            this.grdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMain.Location = new System.Drawing.Point(0, 143);
            this.grdMain.MainView = this.gridView;
            this.grdMain.MenuManager = this.ribbon;
            this.grdMain.Name = "grdMain";
            this.grdMain.Size = new System.Drawing.Size(1370, 460);
            this.grdMain.TabIndex = 1;
            this.grdMain.UseEmbeddedNavigator = true;
            this.grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            this.grdMain.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRegistered);
            this.grdMain.ViewRemoved += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRemoved);
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDO_ID,
            this.colDO_MINIST_MA_ID,
            this.colDO_TESTO,
            this.colDO_IMG,
            this.colDO_AR_ID,
            this.colDO_CODICE_MINST,
            this.colDO_CODICE_EGAF,
            this.colDO_IMG2,
            this.colDO_MULTIMEDIALE,
            this.colDO_STATISTICA,
            this.colDO_COMMENTO,
            this.colDO_FLAG_BLOCCATA,
            this.colDO_NOTE,
            this.colDO_FLAG_BLOCCATA_EGAF,
            this.colDO_NOTE_EGAF,
            this.colDO_TEORICOPRATICO,
            this.colDO_ES_ID,
            this.colDO_FLAG_OBSOLETA,
            this.colDO_TESTOCN,
            this.colDO_TESTOES,
            this.colDO_TESTOMA,
            this.colDO_TESTODE,
            this.colDO_TESTOGB,
            this.colDO_TESTOFR,
            this.colDO_TESTORU,
            this.colDO_PROGRESSIVO,
            this.colDO_STATISTICAV,
            this.colDO_STATISTICAF,
            this.colDO_GRDOMCORR,
            this.colDO_ALTROTESTO,
            this.colDO_TESTO_AIUTO});
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Name = "regolaCambiamento";
            formatConditionRuleExpression1.PredefinedName = "Red Fill";
            gridFormatRule1.Rule = formatConditionRuleExpression1;
            this.gridView.FormatRules.Add(gridFormatRule1);
            this.gridView.GridControl = this.grdMain;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.RowAutoHeight = true;
            this.gridView.OptionsView.ShowChildrenInGroupPanel = true;
            this.gridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_RowStyle);
            this.gridView.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.gridView_MasterRowEmpty);
            this.gridView.MasterRowCollapsed += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.gridView_MasterRowCollapsed);
            this.gridView.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridView_MasterRowGetChildList);
            this.gridView.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridView_MasterRowGetRelationName);
            this.gridView.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridView_MasterRowGetRelationCount);
            this.gridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView_ValidateRow);
            this.gridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.menuScelta,
            this.txtIniziale,
            this.btnSceltaIniziale,
            this.barListItem1,
            this.menuPatenti});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbon.Size = new System.Drawing.Size(1370, 143);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.grpSceltaViaIniziale});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Scelta Esame";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.menuPatenti);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Scelta via menu";
            // 
            // grpSceltaViaIniziale
            // 
            this.grpSceltaViaIniziale.AllowTextClipping = false;
            this.grpSceltaViaIniziale.ItemLinks.Add(this.txtIniziale);
            this.grpSceltaViaIniziale.ItemLinks.Add(this.btnSceltaIniziale);
            this.grpSceltaViaIniziale.Name = "grpSceltaViaIniziale";
            this.grpSceltaViaIniziale.ShowCaptionButton = false;
            this.grpSceltaViaIniziale.Text = "Scelta Via Iniziale";
            // 
            // btnSalvaLayout
            // 
            this.btnSalvaLayout.Location = new System.Drawing.Point(328, 64);
            this.btnSalvaLayout.Name = "btnSalvaLayout";
            this.btnSalvaLayout.Size = new System.Drawing.Size(126, 23);
            this.btnSalvaLayout.TabIndex = 3;
            this.btnSalvaLayout.Text = "Salva Layout";
            this.btnSalvaLayout.UseVisualStyleBackColor = true;
            this.btnSalvaLayout.Click += new System.EventHandler(this.btnSalvaLayout_Click);
            // 
            // controlloOrtografico
            // 
            this.controlloOrtografico.Culture = new System.Globalization.CultureInfo("it-IT");
            this.controlloOrtografico.ParentContainer = null;
            // 
            // colDO_ID
            // 
            this.colDO_ID.FieldName = "DO_ID";
            this.colDO_ID.Name = "colDO_ID";
            this.colDO_ID.Visible = true;
            this.colDO_ID.VisibleIndex = 0;
            this.colDO_ID.Width = 60;
            // 
            // colDO_MINIST_MA_ID
            // 
            this.colDO_MINIST_MA_ID.FieldName = "DO_MINIST_MA_ID";
            this.colDO_MINIST_MA_ID.Name = "colDO_MINIST_MA_ID";
            this.colDO_MINIST_MA_ID.Visible = true;
            this.colDO_MINIST_MA_ID.VisibleIndex = 1;
            this.colDO_MINIST_MA_ID.Width = 60;
            // 
            // colDO_TESTO
            // 
            this.colDO_TESTO.FieldName = "DO_TESTO";
            this.colDO_TESTO.Name = "colDO_TESTO";
            this.colDO_TESTO.Visible = true;
            this.colDO_TESTO.VisibleIndex = 2;
            this.colDO_TESTO.Width = 150;
            // 
            // colDO_IMG
            // 
            this.colDO_IMG.FieldName = "DO_IMG";
            this.colDO_IMG.Name = "colDO_IMG";
            this.colDO_IMG.Visible = true;
            this.colDO_IMG.VisibleIndex = 3;
            this.colDO_IMG.Width = 56;
            // 
            // colDO_AR_ID
            // 
            this.colDO_AR_ID.FieldName = "DO_AR_ID";
            this.colDO_AR_ID.Name = "colDO_AR_ID";
            this.colDO_AR_ID.Width = 56;
            // 
            // colDO_CODICE_MINST
            // 
            this.colDO_CODICE_MINST.FieldName = "DO_CODICE_MINST";
            this.colDO_CODICE_MINST.Name = "colDO_CODICE_MINST";
            this.colDO_CODICE_MINST.Visible = true;
            this.colDO_CODICE_MINST.VisibleIndex = 4;
            this.colDO_CODICE_MINST.Width = 56;
            // 
            // colDO_CODICE_EGAF
            // 
            this.colDO_CODICE_EGAF.FieldName = "DO_CODICE_EGAF";
            this.colDO_CODICE_EGAF.Name = "colDO_CODICE_EGAF";
            this.colDO_CODICE_EGAF.Visible = true;
            this.colDO_CODICE_EGAF.VisibleIndex = 5;
            this.colDO_CODICE_EGAF.Width = 56;
            // 
            // colDO_IMG2
            // 
            this.colDO_IMG2.FieldName = "DO_IMG2";
            this.colDO_IMG2.Name = "colDO_IMG2";
            this.colDO_IMG2.Visible = true;
            this.colDO_IMG2.VisibleIndex = 6;
            this.colDO_IMG2.Width = 56;
            // 
            // colDO_MULTIMEDIALE
            // 
            this.colDO_MULTIMEDIALE.FieldName = "DO_MULTIMEDIALE";
            this.colDO_MULTIMEDIALE.Name = "colDO_MULTIMEDIALE";
            this.colDO_MULTIMEDIALE.Visible = true;
            this.colDO_MULTIMEDIALE.VisibleIndex = 7;
            this.colDO_MULTIMEDIALE.Width = 56;
            // 
            // colDO_STATISTICA
            // 
            this.colDO_STATISTICA.FieldName = "DO_STATISTICA";
            this.colDO_STATISTICA.Name = "colDO_STATISTICA";
            this.colDO_STATISTICA.Width = 56;
            // 
            // colDO_COMMENTO
            // 
            this.colDO_COMMENTO.FieldName = "DO_COMMENTO";
            this.colDO_COMMENTO.Name = "colDO_COMMENTO";
            this.colDO_COMMENTO.Visible = true;
            this.colDO_COMMENTO.VisibleIndex = 8;
            this.colDO_COMMENTO.Width = 56;
            // 
            // colDO_FLAG_BLOCCATA
            // 
            this.colDO_FLAG_BLOCCATA.FieldName = "DO_FLAG_BLOCCATA";
            this.colDO_FLAG_BLOCCATA.Name = "colDO_FLAG_BLOCCATA";
            this.colDO_FLAG_BLOCCATA.Visible = true;
            this.colDO_FLAG_BLOCCATA.VisibleIndex = 9;
            this.colDO_FLAG_BLOCCATA.Width = 56;
            // 
            // colDO_NOTE
            // 
            this.colDO_NOTE.FieldName = "DO_NOTE";
            this.colDO_NOTE.Name = "colDO_NOTE";
            this.colDO_NOTE.Visible = true;
            this.colDO_NOTE.VisibleIndex = 10;
            this.colDO_NOTE.Width = 56;
            // 
            // colDO_FLAG_BLOCCATA_EGAF
            // 
            this.colDO_FLAG_BLOCCATA_EGAF.FieldName = "DO_FLAG_BLOCCATA_EGAF";
            this.colDO_FLAG_BLOCCATA_EGAF.Name = "colDO_FLAG_BLOCCATA_EGAF";
            this.colDO_FLAG_BLOCCATA_EGAF.Width = 56;
            // 
            // colDO_NOTE_EGAF
            // 
            this.colDO_NOTE_EGAF.FieldName = "DO_NOTE_EGAF";
            this.colDO_NOTE_EGAF.Name = "colDO_NOTE_EGAF";
            this.colDO_NOTE_EGAF.Width = 56;
            // 
            // colDO_TEORICOPRATICO
            // 
            this.colDO_TEORICOPRATICO.FieldName = "DO_TEORICOPRATICO";
            this.colDO_TEORICOPRATICO.Name = "colDO_TEORICOPRATICO";
            this.colDO_TEORICOPRATICO.Visible = true;
            this.colDO_TEORICOPRATICO.VisibleIndex = 11;
            this.colDO_TEORICOPRATICO.Width = 56;
            // 
            // colDO_ES_ID
            // 
            this.colDO_ES_ID.FieldName = "DO_ES_ID";
            this.colDO_ES_ID.Name = "colDO_ES_ID";
            this.colDO_ES_ID.Width = 56;
            // 
            // colDO_FLAG_OBSOLETA
            // 
            this.colDO_FLAG_OBSOLETA.FieldName = "DO_FLAG_OBSOLETA";
            this.colDO_FLAG_OBSOLETA.Name = "colDO_FLAG_OBSOLETA";
            this.colDO_FLAG_OBSOLETA.Width = 56;
            // 
            // colDO_TESTOCN
            // 
            this.colDO_TESTOCN.FieldName = "DO_TESTOCN";
            this.colDO_TESTOCN.Name = "colDO_TESTOCN";
            this.colDO_TESTOCN.Width = 56;
            // 
            // colDO_TESTOES
            // 
            this.colDO_TESTOES.FieldName = "DO_TESTOES";
            this.colDO_TESTOES.Name = "colDO_TESTOES";
            this.colDO_TESTOES.Width = 56;
            // 
            // colDO_TESTOMA
            // 
            this.colDO_TESTOMA.FieldName = "DO_TESTOMA";
            this.colDO_TESTOMA.Name = "colDO_TESTOMA";
            this.colDO_TESTOMA.Width = 56;
            // 
            // colDO_TESTODE
            // 
            this.colDO_TESTODE.FieldName = "DO_TESTODE";
            this.colDO_TESTODE.Name = "colDO_TESTODE";
            this.colDO_TESTODE.Visible = true;
            this.colDO_TESTODE.VisibleIndex = 12;
            this.colDO_TESTODE.Width = 56;
            // 
            // colDO_TESTOGB
            // 
            this.colDO_TESTOGB.FieldName = "DO_TESTOGB";
            this.colDO_TESTOGB.Name = "colDO_TESTOGB";
            this.colDO_TESTOGB.Width = 56;
            // 
            // colDO_TESTOFR
            // 
            this.colDO_TESTOFR.FieldName = "DO_TESTOFR";
            this.colDO_TESTOFR.Name = "colDO_TESTOFR";
            this.colDO_TESTOFR.Visible = true;
            this.colDO_TESTOFR.VisibleIndex = 13;
            this.colDO_TESTOFR.Width = 56;
            // 
            // colDO_TESTORU
            // 
            this.colDO_TESTORU.FieldName = "DO_TESTORU";
            this.colDO_TESTORU.Name = "colDO_TESTORU";
            this.colDO_TESTORU.Width = 56;
            // 
            // colDO_PROGRESSIVO
            // 
            this.colDO_PROGRESSIVO.FieldName = "DO_PROGRESSIVO";
            this.colDO_PROGRESSIVO.Name = "colDO_PROGRESSIVO";
            this.colDO_PROGRESSIVO.Visible = true;
            this.colDO_PROGRESSIVO.VisibleIndex = 14;
            this.colDO_PROGRESSIVO.Width = 56;
            // 
            // colDO_STATISTICAV
            // 
            this.colDO_STATISTICAV.FieldName = "DO_STATISTICAV";
            this.colDO_STATISTICAV.Name = "colDO_STATISTICAV";
            this.colDO_STATISTICAV.Width = 56;
            // 
            // colDO_STATISTICAF
            // 
            this.colDO_STATISTICAF.FieldName = "DO_STATISTICAF";
            this.colDO_STATISTICAF.Name = "colDO_STATISTICAF";
            this.colDO_STATISTICAF.Width = 56;
            // 
            // colDO_GRDOMCORR
            // 
            this.colDO_GRDOMCORR.FieldName = "DO_GRDOMCORR";
            this.colDO_GRDOMCORR.Name = "colDO_GRDOMCORR";
            this.colDO_GRDOMCORR.Width = 56;
            // 
            // colDO_ALTROTESTO
            // 
            this.colDO_ALTROTESTO.FieldName = "DO_ALTROTESTO";
            this.colDO_ALTROTESTO.Name = "colDO_ALTROTESTO";
            this.colDO_ALTROTESTO.Visible = true;
            this.colDO_ALTROTESTO.VisibleIndex = 15;
            this.colDO_ALTROTESTO.Width = 56;
            // 
            // colDO_TESTO_AIUTO
            // 
            this.colDO_TESTO_AIUTO.FieldName = "DO_TESTO_AIUTO";
            this.colDO_TESTO_AIUTO.Name = "colDO_TESTO_AIUTO";
            this.colDO_TESTO_AIUTO.Visible = true;
            this.colDO_TESTO_AIUTO.VisibleIndex = 16;
            this.colDO_TESTO_AIUTO.Width = 103;
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
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrincipale_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarSubItem menuScelta;
        private DevExpress.XtraGrid.GridControl grdMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
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
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_MINIST_MA_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_IMG;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_AR_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_CODICE_MINST;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_CODICE_EGAF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_IMG2;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_MULTIMEDIALE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_STATISTICA;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_COMMENTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_FLAG_BLOCCATA;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_NOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_FLAG_BLOCCATA_EGAF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_NOTE_EGAF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TEORICOPRATICO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ES_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_FLAG_OBSOLETA;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOCN;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOES;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOMA;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTODE;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOGB;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTOFR;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTORU;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_PROGRESSIVO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_STATISTICAV;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_STATISTICAF;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_GRDOMCORR;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_ALTROTESTO;
        private DevExpress.XtraGrid.Columns.GridColumn colDO_TESTO_AIUTO;
    }
}

