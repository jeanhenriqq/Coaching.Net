using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double PR1, PR2, media;
            Console.Write("Digite a primeira nota: ");
            PR1 = double.Parse(Console.ReadLine());
            Console.Write("\nDigite a segunda nota: ");
            PR2 = double.Parse(Console.ReadLine());
            media = (PR1 + PR2) / 2;
            Console.Write("\nMédia final: {0}", media);
            Console.ReadKey();
        }
    }
}
