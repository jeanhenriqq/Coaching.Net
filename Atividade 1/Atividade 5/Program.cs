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
            int a;
            Console.Write("Digite um número inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nO número digitado foi: {0}", a);
            Console.ReadKey();
        }
    }
}
