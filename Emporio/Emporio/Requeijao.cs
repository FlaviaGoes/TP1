using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Requeijao : Produto
    {
        public double aumento = 0.02;
        public Requeijao(String nome, double preco, int quantidade) : base(nome, preco, quantidade)
        {
        }

        public override double ReajustarPreco()
        {
            Preco = Preco * (1 + aumento);
            return Preco;
        }

    }
}
