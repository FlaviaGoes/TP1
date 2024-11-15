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
        public Requeijao(int id, String nome, String descricao, double preco) : base(id, nome, descricao, preco)
        {
        }

        public override double ReajustarPreco()
        {
            Preco = Preco * (1 + aumento / 100);
            return Preco;
        }
    }
}
