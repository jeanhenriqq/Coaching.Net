using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_12
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, media;
            Console.Write("Digite um número: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("\nDigite outro número: ");
            b = float.Parse(Console.ReadLine());
            media = (a + b) / 2;
            Console.WriteLine("Média = {0}", media);
            Console.ReadLine();
        }
    }
}
