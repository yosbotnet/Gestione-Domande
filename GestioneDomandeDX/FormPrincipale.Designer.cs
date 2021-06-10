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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grdMain = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.menuScelta = new DevExpress.XtraBars.BarSubItem();
            this.txtIniziale = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnSceltaIniziale = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.menuPatenti = new DevExpress.XtraBars.BarSubItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.grpSceltaViaIniziale = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
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
            this.grdMain.MenuManager = this.ribbonControl1;
            this.grdMain.Name = "grdMain";
            this.grdMain.Size = new System.Drawing.Size(1370, 460);
            this.grdMain.TabIndex = 1;
            this.grdMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView,
            this.gridView1});
            this.grdMain.ViewRegistered += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRegistered);
            this.grdMain.ViewRemoved += new DevExpress.XtraGrid.ViewOperationEventHandler(this.grdMain_ViewRemoved);
            // 
            // gridView
            // 
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Name = "regolaCambiamento";
            formatConditionRuleExpression2.PredefinedName = "Red Fill";
            gridFormatRule2.Rule = formatConditionRuleExpression2;
            this.gridView.FormatRules.Add(gridFormatRule2);
            this.gridView.GridControl = this.grdMain;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplaceHideCurrentRow;
            this.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled;
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
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.menuScelta,
            this.txtIniziale,
            this.btnSceltaIniziale,
            this.barListItem1,
            this.menuPatenti});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1370, 143);
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
            // FormPrincipale
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1370, 603);
            this.Controls.Add(this.grdMain);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FormPrincipale";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Gestione Domande";
            this.Load += new System.EventHandler(this.FormPrincipale_Load);
            this.SizeChanged += new System.EventHandler(this.FormPrincipale_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
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
    }
}

