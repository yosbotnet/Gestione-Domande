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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.SetBoundPropertyName(this.comboBox1, "");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "V",
            "F"});
            this.comboBox1.Location = new System.Drawing.Point(398, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // memoEdit1
            // 
            this.SetBoundPropertyName(this.memoEdit1, "");
            this.memoEdit1.Location = new System.Drawing.Point(55, 16);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(269, 54);
            this.memoEdit1.TabIndex = 4;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.comboBox1);
            this.Name = "EditForm";
            this.Size = new System.Drawing.Size(616, 287);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}
