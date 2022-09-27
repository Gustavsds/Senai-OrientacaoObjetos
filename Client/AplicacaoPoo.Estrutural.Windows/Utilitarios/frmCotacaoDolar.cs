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

            var list = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Libras);
            list.Add(MoedaHelper.Euro);
            cmbMoedaDesejada.DataSource = list;
            cmbMoedaDesejada.SelectedIndex = 0;
        }

        private void txtQuantiaDolar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtQuantia.Text == "")

                {
                    return;
                }
                decimal resultado = 0;

                var quantia = decimal.Parse(txtQuantia.Text);
                var moeda = new ConverterMoedaService();
                resultado = moeda.ConverterDolarEmReal(quantia);

                switch (cmbMoedaDesejada.SelectedValue)
                {

                    case "Dolar Americano":
                        resultado = moeda.ConverterDolarEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Dolar} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                        break;

                    case "Euro":
                        resultado = moeda.ConverterEuroEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Euro} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                        break;

                    case "Libra Esterlina":
                        resultado = moeda.ConverterLibraEmReal(quantia);
                        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Libras} igual a";
                        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

                        break;

                }

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dalor é um valor decimal");
                txtQuantia.Focus();

            }

           
            }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region
            //decimal resultado = 0;

            //var quantia = decimal.Parse(txtQuantia.Text);
            //var moeda = new ConverterMoedaService();
            //resultado = moeda.ConverterDolarEmReal(quantia);

            //switch (cmbMoedaDesejada.SelectedValue)
            //{

            //    case "Dolar Americano":
            //        resultado = moeda.ConverterDolarEmReal(quantia);
            //        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Dolar} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;

            //    case "Euro":
            //        resultado = moeda.ConverterEuroEmReal(quantia); 
            //        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Euro} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;

            //    case "Libra Esterlina":
            //        resultado = moeda.ConverterLibraEmReal(quantia);
            //        lblPrimeiroValor.Text = $"{quantia} {MoedaHelper.Libras} igual a";
            //        lblSegundoValor.Text = $"{resultado} {MoedaHelper.Real}";

            //        break;
            #endregion
            if (txtQuantia.Text == "") return;
            var quantia = decimal.Parse(txtQuantia.Text);
            var moedaService = new ConverterMoedaService();
            switch(cmbMoedaDesejada.SelectedValue)
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
                        break ;
                    }
                case MoedaHelper.Libras:
                    {
                        var valorConvertido = moedaService.ConverterLibraEmReal(quantia);    
                        break;
                    }
            }

        }
    }
}