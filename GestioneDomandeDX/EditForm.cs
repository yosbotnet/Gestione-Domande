using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace GestioneDomandeDX
{
    public partial class EditForm : Form
    {
        domande dom;
        public EditForm()
        {
            dom = new domande();
            InitializeComponent();
        }

        private void btnImposta_Click(object sender, EventArgs e)
        {
            typeof(domande).GetProperty(cmbSceltaValore.SelectedItem.ToString()).SetValue(dom, memoEdit.EditValue);
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dom);
        }

        private void cmbSceltaValore_SelectedValueChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;
            string txt = cmb.SelectedItem as string;
            if(!string.IsNullOrWhiteSpace(txt))
                memoEdit.EditValue = typeof(domande).GetProperty(txt).GetValue(dom);
        }
        //15 campi
    }
}
