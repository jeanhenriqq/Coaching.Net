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
            int a, b;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.Write("{0} é maior do que {1}.", a, b);
            }
            if(b>a)
            {
                Console.Write(b + " é maior do que " + a + ".");
            }
            if(a == b)
            {
                Console.Write("Os números são iguais.");
            }
            Console.ReadLine();
        }
    }
}// Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles 
// é o maior, ou a mensagem "A = B" caso sejam iguais.
