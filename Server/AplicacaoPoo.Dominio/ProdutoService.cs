using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Dominio
{
    public class ProdutoService
    {
        public List<Produto> ListagemProdutosFake()
        {
            var lista = new List<Produto>();

            lista.Add(new Produto()
            {
                Id = 7505478,
                NomeProduto = "Linguiça Toscana Grossa",
                ValorUnitario = 45m
            });
            lista.Add(new Produto()
            {
                Id = 8505178,
                NomeProduto = "Acém",
                ValorUnitario = 54m
            });
            lista.Add(new Produto()
            {
                Id = 1548845,
                NomeProduto = "Contrafilé",
                ValorUnitario = 65m
            });
            return lista;
        }

    }
}
