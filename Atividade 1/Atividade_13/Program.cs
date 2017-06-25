using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, x , soma = 0;

            for (x = 0; x < 4; x++)
            {
                Console.WriteLine("Digite um número: ");
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    soma = soma + a;
                }
            }

            Console.WriteLine("\nA soma dos números é = {0};", soma);
            Console.ReadKey();

        }
    }
}// Ler 4 números inteiros e calcular a soma dos que forem par.
