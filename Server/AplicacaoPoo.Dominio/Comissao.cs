using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class Comissao
    {
        public static double CalcularComissao (double precoProduto, int quantidadeVendida)
        {
            double resultado = precoProduto * quantidadeVendida;
            resultado = resultado * 0.05;
            Math.Round(resultado, 2);
            return resultado;   
        }
    }
}
