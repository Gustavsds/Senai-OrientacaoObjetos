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

        private void btnComissao_Click(object sender, EventArgs e)
        {
            var form = new frmComissao();   
            form.Show();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            var form = new frmCotacaoDolar();
            form.Show();
        }
    }
}
