using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Cotacao
    {
        public static double ConversaoDolar(double cotacao, double quantia) 
        {
            double resultado = cotacao * quantia;
            return resultado;
        }
            

    }
}
