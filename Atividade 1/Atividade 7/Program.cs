using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Digite um numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a - 1;
            c = a + 1;
            Console.Write("\nO número digitado foi: {0} , o antecessor é: {1}, o sucessor é: {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
