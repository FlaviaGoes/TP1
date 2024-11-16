using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;

            CestadeCompras ListadeCompras = new CestadeCompras("Flavia");

            Pao pao = new Pao("Pao de Batata", 3.5, 6);
            Presunto presunto = new Presunto("Presunto", 5.5, 10);
            Mussarela mussarela = new Mussarela("Mussarela", 6.5, 10);
            Requeijao requeijao = new Requeijao("Requeijao", 4.5, 15);
            Tapioca tapioca = new Tapioca("Tapioca", 14.5, 10);


            do
            {
                op = Menu();
                switch (op)
                {
                    case 1:
                        ListadeCompras.AdicionarProduto(mussarela);
                        break;
                    case 2:
                        ListadeCompras.AdicionarProduto(presunto);
                        break;
                    case 3:
                        ListadeCompras.AdicionarProduto(pao);
                        break;
                    case 4:
                        ListadeCompras.AdicionarProduto(tapioca);
                        break;
                    case 5:
                        ListadeCompras.AdicionarProduto(requeijao);
                        break;
                    case 6:
                        ListadeCompras.Reajuste();
                        break;
                    case 7:
                        ListadeCompras.ExibirProdutos();
                        break;
                    case 8:
                        Console.WriteLine($"Total da Compra: {Math.Round(ListadeCompras.ExibirPreco(), 2)};");
                        break;

                }
            } while (op > 0 && op < 9);

             int Menu()
            {
                int val;
                Console.WriteLine("[1] - Incluir Mussarela na cesta");
                Console.WriteLine("[2] - Incluir Presunto na cesta");
                Console.WriteLine("[3] - Incluir Pao na cesta");
                Console.WriteLine("[4] - Incluir Tapioca na cesta");
                Console.WriteLine("[5] - Incluir Requeijao na cesta");
                Console.WriteLine("[6] - Reajustar o preço de todos os produtos");
                Console.WriteLine("[7] - Exibir a cesta de produtos");
                Console.WriteLine("[8] - Exibir total da compra");

                val = Convert.ToInt32(Console.ReadLine());
                return val;
            }

        }
    }
}
