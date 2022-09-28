using AplicacaoPoo.Dominio.Helpers;
using AplicacaoPoo.Dominio.services;

namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a";
            lblSegundoValor.Text = $"5,12 {MoedaHelper.Real}";
            txtQuantia.Text = "1";
            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Libras);
            list.Add(MoedaHelper.Euro);
            cmbMoedaDesejada.DataSource = list;
            cmbMoedaDesejada.SelectedIndex = 0;
        }

        private void txtQuantiaDolar_TextChanged(object sender, EventArgs e)
        {

            if(txtQuantia.Text == "")
            {
                cmbMoedaDesejada.Enabled = false;
                return;
            }
            cmbMoedaDesejada.Enabled = true;  
            EfetuarConversaoMoeda();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EfetuarConversaoMoeda();
        }
        private void EfetuarConversaoMoeda()
        {
            
            try
            {
            #region Caluculo da conversão
            if (txtQuantia.Text == "") return;
            var quantia = decimal.Parse(txtQuantia.Text);
            var moedaService = new ConverterMoedaService();
            switch (cmbMoedaDesejada.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaService.ConverterDolarEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaService.ConverterEuroEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
                case MoedaHelper.Libras:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{valorConvertido} {MoedaHelper.Real}";

                        break;
                    }
            }
            #endregion
            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa informar um valor númerico");
                txtQuantia.Text = string.Empty;
                txtQuantia.Focus();
            }
        }

    }
}