using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Digite um número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            y = int.Parse(Console.ReadLine());

            if (x % y == 0)
            {
                Console.Write("{0} (x) é múltiplo de {1} (y).", x, y);
            }
            else
            {
                Console.Write("{0} (x) não é múltiplo de {1} (y).", x, y);
            }
            Console.ReadLine();
        }
    }
}//Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
