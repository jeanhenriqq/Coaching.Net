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
            double a = 0, b, c, delta; //Como int, retornava erro "Não é possível realizar a conversão de double pra int"
            double x1, x2 = 0;

            while (a == 0)
            {
                Console.Write("Digite o primeiro coeficiente: ");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("\nDigite um valor diferente de zero, o primeiro coeficiente nunca pode ser 0 em uma equação do segundo grau.");
                    a = double.Parse(Console.ReadLine());
                }

            }
            Console.Write("Digite o segundo coeficiente: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro coeficiente: ");
            c = double.Parse(Console.ReadLine());

            delta = (Math.Pow(b, 2)) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("Não existem raizes Reais.");
            }
            if (delta == 0)
            {
                x1 = -b + Math.Sqrt(delta) / (2 * a);
                x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Raizes iguais.");
                Console.WriteLine("\nX1 = {0} e X2 = {1}.", x1, x2);
            }
            if (delta > 0)
            {
                x1 = -b + Math.Sqrt(delta) / (2 * a);
                x2 = -b - Math.Sqrt(delta) / (2 * a);
                Console.WriteLine("Raizes diferentes.");
                Console.WriteLine("\nX1 = {0} e X2 = {1}.", x1, x2);
            }
            Console.ReadKey();
        }
    }
}// Ler os três coeficientes de uma equação de segundo grau e determinar 
 // suas raízes
 // Raiz Quadrada = Math.Sqrt( valor da raiz quadrada para calcular aqui dentro).
 //      Potência = Math.Pow (b, 2)   Obs: Observe que base = b e expoente = 2; (base, expoente).
 // Pose-se fazer assim também (b * b) para potência.