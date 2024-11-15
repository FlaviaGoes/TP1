using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Mussarela : Produto
    {
        public double aumento = 0.005;
        public Mussarela(int id, String nome, String descricao, double preco) : base(id, nome, descricao, preco)
        {
        }

        public override double ReajustarPreco()
        {
            Preco = Preco * (1 + aumento / 100);
            return Preco;
        }
    }
}
