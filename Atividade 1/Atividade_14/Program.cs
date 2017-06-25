using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("O maior número é {0}.",a);
            }
            if (b > a && b > c)
            {
                Console.WriteLine("O maior número é {0}.", b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine("O maior número é {0}.", c);
            }
            Console.ReadKey();
        }
    }
}// 14.   Ler três valores e determinar o maior dentre eles.
