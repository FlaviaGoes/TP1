using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    abstract class Produto
    {
        private static int proximoId = 1;
        public int Id { get; private set; }
        public String Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(String nome, double preco, int quantidade)
        {
            this.Id = proximoId;
            proximoId++;
            this.Nome = nome;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public virtual void ExibirProduto()
        {
            Console.WriteLine($"Id: {Id} Nome: {Nome}");
            Console.WriteLine($"Quantidade: {Quantidade} Valor: {Preco}\n");
        }

        public abstract double ReajustarPreco();

    }
}
