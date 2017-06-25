using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, result;
            Console.Write("Digite um número: ");
            a = Double.Parse(Console.ReadLine());
            result = a / 3;
            Console.Write("\nA terça parte é: {0:#.00}", result);
            Console.ReadLine();
        }
    }
}
