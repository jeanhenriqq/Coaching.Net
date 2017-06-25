using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_15
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
            Console.Write("Digite um número: \n");
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c && b > c)
            {
                Console.WriteLine("{0}, {1}, {2}", a,b,c);
            }
            if (a > b && a > c && c > b)
            {
                Console.WriteLine("{0}, {1}, {2}", a,c,b);
            }
            if (b > a && b > c && a > c)
            {
                Console.WriteLine("{0}, {1}, {2}", b,a,c);
            }
            if (b > a && b > c && c > a)
            {
                Console.WriteLine("{0}, {1}, {2}", b,c,a);
            }
            if (c > a && c > b && a > b)
            {
                Console.WriteLine("{0}, {1}, {2}", c, a, b);
            }
            if (c > a && c > b && b > a)
            {
                Console.WriteLine("{0}, {1}, {2}", c,b,a);
            }
            Console.ReadKey();
        }
    }
}// Ler três valores e colocá-los em ordem decrescente.
