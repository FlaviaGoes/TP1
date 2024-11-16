using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Tapioca : Produto
    {
        public double aumento = 0.01;
        public Tapioca(String nome, double preco, int quantidade) : base(nome, preco, quantidade)
        {
        }

        public override double ReajustarPreco()
        {
            Preco = Preco * (1 + aumento);
            return Preco;
        }

    }
}
