using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Digite o primeiro número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nDigite o segundo número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nOs números foram: {0} e {1}.", a, b);
            Console.ReadKey();
        }
    }
}
