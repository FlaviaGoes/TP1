using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Tapioca : Produto
    {
        public double aumento = 0.01;
        public Tapioca(int id, String nome, String descricao, double preco) : base (id, nome, descricao, preco)
        {
        }

        public override double ReajustarPreco()
        {
            Preco = Preco * (1 + aumento / 100);
            return Preco;
        }
    }
}
