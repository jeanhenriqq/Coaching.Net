using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, produto;
            Console.Write("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());

            produto = a * b;
            Console.Write(" {0} * {1} = {2}", a, b, produto);
            Console.ReadKey();
        }
    }
}
