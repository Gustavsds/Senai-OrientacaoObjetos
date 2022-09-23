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
        }

        private void txtQuantiaDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantiaDolar.Text == "")

                {
                    return;
                }
                var valorEmDolar = decimal.Parse(txtQuantiaDolar.Text);

                var moeda = new ConverterMoedaService();
                var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

                lblPrimeiroValor.Text = $"{valorEmDolar} {MoedaHelper.Dolar} igual a";
                lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQuantiaDolar.Focus();

            }

           
            }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtQuantiaDolar.Text);


            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            switch (cmbMoedaDesejada.Text)
            {

                case "Dólar Americano":
                    lblPrimeiroValor.Text = $"{resultado} {MoedaHelper.Dolar}";

                    break;


            }

        }
    }
}
