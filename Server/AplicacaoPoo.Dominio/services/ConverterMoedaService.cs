using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio.services
{
    //satatic class c#
    //partial class c#
    //abstract class c#
    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.12m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.0m;
        public decimal ConverterDolarEmReal(decimal valor)
        {
            
            return valor * CotacaoDolar;
        }
        public decimal ConverterLibraEmReal(decimal valor)
        {
            return valor * CotacaoLibra;
        }
        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }
    }
}
