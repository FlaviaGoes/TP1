using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class CestadeCompras
    {
        private static int proximoId = 1;
        public String Usuario { get; set; }
        public int Id { get; private set; }
        public double Total { get; set; }
        public List<Produto> ListaDeProdutos { get; set; }

        public CestadeCompras(String usuario)
        {
            this.Id = proximoId;
            proximoId++;
            this.Usuario = usuario;
            this.ListaDeProdutos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            ListaDeProdutos.Add(produto);
        }

        public void ExibirProdutos()
        {
            foreach (Produto p in ListaDeProdutos)
            {
                Console.WriteLine(p.Nome);
                Console.WriteLine(p.Preco);
            }
        }

        public double ExibirPreco()
        {
            Total = 0;
            foreach (Produto p in ListaDeProdutos)
            {
                Total += p.Preco;
            }

            return Total;
        }

        public void Reajuste()
        {
            foreach (Produto p in ListaDeProdutos)
            {
                p.ReajustarPreco();
                p.ExibirProduto();
            }

        }

    }
}
