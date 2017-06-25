using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sucessor;
            Console.Write("Digite um número:  ");
            a = int.Parse(Console.ReadLine());
            sucessor = a + 1;
            Console.Write("O sucessor de {0} é {1}.", a, sucessor);
            Console.ReadLine();
        }
    }
}// Leia um número e exiba o seu sucessor.
