using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void conversorDeMoedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.MdiParent = this;
            form.Show();
        }

        private void comissionamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();   
            form.MdiParent = this;
            form.Show();
        }
    }
}
