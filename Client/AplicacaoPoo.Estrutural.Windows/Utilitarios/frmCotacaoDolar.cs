using AplicacaoPoo.Dominio;
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
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double cotacao = double.Parse(txtCotacaoAtual.Text);
            double quantia = double.Parse(txtQuantiaDolar.Text);
            lblResultado.Text = Cotacao.ConversaoDolar(cotacao, quantia).ToString();
            MessageBox.Show(lblResultado.Text); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = null;
            txtCotacaoAtual.Text = null;
            txtQuantiaDolar.Text = null;
        }
    }
}
