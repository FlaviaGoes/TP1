using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    abstract class Produto
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Descricao {  get; set; }
        public double Preco {  get; set; }

        public Produto(int id, String nome, String descricao, double preco) {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public virtual void ExibirProduto()
        {
            Console.WriteLine($"Id: {Id} Nome: {Nome} Descricao: {Descricao} Valor: {Valor}");
        }

        public abstract double ReajustarPreco();

    }
}
