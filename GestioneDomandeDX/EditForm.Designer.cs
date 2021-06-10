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
            this.testo = new DevExpress.XtraEditors.TextEdit();
            this.testoFR = new DevExpress.XtraEditors.TextEdit();
            this.testoDE = new DevExpress.XtraEditors.TextEdit();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.testo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testoFR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testoDE.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // testo
            // 
            this.SetBoundPropertyName(this.testo, "");
            this.testo.EditValue = "boh";
            this.testo.Location = new System.Drawing.Point(61, 16);
            this.testo.Name = "testo";
            this.testo.Size = new System.Drawing.Size(100, 20);
            this.testo.TabIndex = 0;
            // 
            // testoFR
            // 
            this.SetBoundPropertyName(this.testoFR, "");
            this.testoFR.Location = new System.Drawing.Point(61, 61);
            this.testoFR.Name = "testoFR";
            this.testoFR.Size = new System.Drawing.Size(100, 20);
            this.testoFR.TabIndex = 1;
            // 
            // testoDE
            // 
            this.SetBoundPropertyName(this.testoDE, "");
            this.testoDE.Location = new System.Drawing.Point(61, 108);
            this.testoDE.Name = "testoDE";
            this.testoDE.Size = new System.Drawing.Size(100, 20);
            this.testoDE.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.SetBoundPropertyName(this.comboBox1, "");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "V",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(280, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.SetBoundPropertyName(this.comboBox2, "");
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBox2.Location = new System.Drawing.Point(280, 64);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.SetBoundPropertyName(this.comboBox3, "");
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(280, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 5;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.testoDE);
            this.Controls.Add(this.testoFR);
            this.Controls.Add(this.testo);
            this.Name = "EditForm";
            this.Size = new System.Drawing.Size(616, 287);
            ((System.ComponentModel.ISupportInitialize)(this.testo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testoFR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testoDE.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit testo;
        private DevExpress.XtraEditors.TextEdit testoDE;
        private DevExpress.XtraEditors.TextEdit testoFR;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
