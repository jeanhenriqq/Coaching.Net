using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
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

            if (a > (b + c))
            {
                Console.Write(a + " é maior do que " + b + " + " + c);
            }
            else
            {
                Console.WriteLine(a + " não é maior do que " + b + " + " + c);
            }
            Console.Read();
        }
    }
}// Fazer um algoritmo para ler 03 números reais do teclado e verificar se o 
// primeiro é maior que a soma dos outros dois.

