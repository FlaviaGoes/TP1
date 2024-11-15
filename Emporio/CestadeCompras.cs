using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class CestadeCompras
    {
        public String Usuario {  get; set; }
        public int Id {  get; set; }
        public List<Produto> ListaDeProdutos { get; set; }

        public CestadeCompras(int id, String usuario) {
            this.Id = id;
            this.Usuario = usuario;
            this.ListaDeProdutos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto) { 
            ListaDeProdutos.Add(produto);
        }

        public void ExibirProduto()
        {
            foreach (Produto p in ListaDeProdutos)
            {
                Console.WriteLine(p);
            }

    }
}
