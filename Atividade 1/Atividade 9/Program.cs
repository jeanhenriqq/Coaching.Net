using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;
            Console.Write("Digite um número: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite um número: ");
            b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;
            Console.Write("\nSoma = {0}", soma);
            Console.ReadKey();
        }
    }
}
