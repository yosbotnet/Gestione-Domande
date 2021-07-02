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
        private void btnInserisci_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dom);
        }
        
    }
}
