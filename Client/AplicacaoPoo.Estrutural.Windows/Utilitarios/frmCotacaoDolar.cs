using AplicacaoPoo.Dominio.services;

namespace AplicacaoPoo.Estrutural.Windows.Utilitarios
{
    public partial class frmCotacaoDolar : Form
    {
        public frmCotacaoDolar()
        {
            InitializeComponent();
            btnConverter.Enabled = false;
        }

        private void txtQuantiaDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantiaDolar.Text == "")
                {
                    btnConverter.Enabled = false;
                    return;
                }
                var resultado = decimal.Parse(txtQuantiaDolar.Text);
                btnConverter.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQuantiaDolar.Focus();
                btnConverter.Enabled = false;

            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            var valorEmDolar = decimal.Parse(txtQuantiaDolar.Text);
            var moeda = new ConverterMoedaService();
            var resultado = moeda.ConverterDolarEmReal(valorEmDolar);

            MessageBox.Show($"Valor convertido é : {resultado} em dolares");
        }
    }
}
