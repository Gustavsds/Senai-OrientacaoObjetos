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

namespace AplicacaoPoo.Estrutural.Windows
{
    public partial class frmComissao2 : Form
    {
        public frmComissao2()
        {
            InitializeComponent();
            btnEnviar2.Enabled = false;
            var listaCodigo = new ProdutoService();

            cmbCodigoProduto2.DataSource = listaCodigo.ListagemProdutosFake();
            cmbCodigoProduto2.DisplayMember = "NomeProduto";
            cmbCodigoProduto2.ValueMember = "Id";
           
        }


    }
}
