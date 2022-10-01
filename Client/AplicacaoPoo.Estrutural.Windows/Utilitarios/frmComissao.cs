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
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
            txtCodigoProduto.Enabled = false;
            txtPrecoProduto.Enabled = false;
            txtQuantidadeVendida.Enabled = false;  
            btnEnviar.Enabled = false;
            

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            double precoProduto = double.Parse(txtPrecoProduto.Text);
            int quantidadeVendida = int.Parse(txtQuantidadeVendida.Text);
            string nome = txtNomeVendedor.Text;
            int codigoProduto = int.Parse(txtCodigoProduto.Text);


            var resultadoComissao = Comissao.CalcularComissao(precoProduto, quantidadeVendida).ToString();
            

            ltbInformacoes.Items.Add("Colaborador: "+ nome);
            ltbInformacoes.Items.Add("codigo do produto: "+ codigoProduto);
            ltbInformacoes.Items.Add("Quantidade Vendida: " + quantidadeVendida);
            ltbInformacoes.Items.Add("Valor do produto: $" + precoProduto);
        }

        private void txtNomeVendedor_TextChanged(object sender, EventArgs e)
        {
            //bool result = txtNomeVendedor.Text.All(char.IsLetter);
            if (txtNomeVendedor.Text.All(char.IsNumber))
            {
                errorProvider1.SetError(txtNomeVendedor, "Apenas letras são permitidas");
                txtCodigoProduto.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtNomeVendedor, "");
                txtCodigoProduto.Enabled = true;
            }
        }

        private void txtCodigoProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoProduto.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(txtCodigoProduto, "Apenas numeros inteiros são permitidos");
                txtPrecoProduto.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtCodigoProduto, "");
                txtPrecoProduto.Enabled = true;
            }
        }

        private void txtPrecoProduto_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecoProduto.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(txtPrecoProduto, "Apenas numeros são permitidos");
                txtQuantidadeVendida.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtPrecoProduto, "");
                txtQuantidadeVendida.Enabled = true;
            }
        }

        private void txtQuantidadeVendida_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantidadeVendida.Text.All(char.IsLetter))
            {
                errorProvider1.SetError(txtQuantidadeVendida, "Apenas numeros são permitidos");
                btnEnviar.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtQuantidadeVendida, "");
                btnEnviar.Enabled = true;
            }
        }
    }
}
