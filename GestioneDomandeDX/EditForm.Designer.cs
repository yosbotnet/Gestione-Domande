namespace GestioneDomandeDX
{
    partial class EditForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbSceltaValore = new System.Windows.Forms.ComboBox();
            this.memoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.btnImposta = new System.Windows.Forms.Button();
            this.btnInserisci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSceltaValore
            // 
            this.cmbSceltaValore.FormattingEnabled = true;
            this.cmbSceltaValore.Items.AddRange(new object[] {
            "DO_TESTO",
            "DO_TESTOFR",
            "DO_TESTODE",
            "DO_ALTROTESTO",
            "DO_TESTOAIUTO",
            "DO_CODICE_MINST",
            "DO_CODICE_EGAF"});
            this.cmbSceltaValore.Location = new System.Drawing.Point(398, 17);
            this.cmbSceltaValore.Name = "cmbSceltaValore";
            this.cmbSceltaValore.Size = new System.Drawing.Size(121, 21);
            this.cmbSceltaValore.TabIndex = 3;
            this.cmbSceltaValore.SelectedValueChanged += new System.EventHandler(this.cmbSceltaValore_SelectedValueChanged);
            // 
            // memoEdit
            // 
            this.memoEdit.Location = new System.Drawing.Point(55, 16);
            this.memoEdit.Name = "memoEdit";
            this.memoEdit.Size = new System.Drawing.Size(286, 82);
            this.memoEdit.TabIndex = 4;
            // 
            // btnImposta
            // 
            this.btnImposta.Location = new System.Drawing.Point(55, 105);
            this.btnImposta.Name = "btnImposta";
            this.btnImposta.Size = new System.Drawing.Size(286, 23);
            this.btnImposta.TabIndex = 5;
            this.btnImposta.Text = "Imposta";
            this.btnImposta.UseVisualStyleBackColor = true;
            this.btnImposta.Click += new System.EventHandler(this.btnImposta_Click);
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(55, 187);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(464, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 248);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.btnImposta);
            this.Controls.Add(this.memoEdit);
            this.Controls.Add(this.cmbSceltaValore);
            this.Name = "EditForm";
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbSceltaValore;
        private DevExpress.XtraEditors.MemoEdit memoEdit;
        private System.Windows.Forms.Button btnImposta;
        private System.Windows.Forms.Button btnInserisci;
    }
}
