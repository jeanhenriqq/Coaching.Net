using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resto = 0, quociente = 0;

            Console.Write("Digite o 1º número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o 2º número: ");
            b = int.Parse(Console.ReadLine());

            if(b == 0)
            {
                Console.WriteLine("Não existe divisão por 0");
                Console.ReadKey();
            }
            else
            {
                quociente = a / b;
                resto = a % b;
                Console.Write("Quociente: {0}. \nResto: {1}.", quociente, resto);
                Console.ReadLine();
            }
        }
    }
}// Ler dois números inteiros, X e Y, e imprimir o quociente e o resto da 
// divisão inteira entre eles.
