using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma = 0, produto = 0, quociente = 0;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());

            if(b == 0)
            {
                Console.WriteLine("Não existe divisão por 0.");
            }
            else
            {
                soma = a + b;
                produto = a % b;
                quociente = a / b;
                Console.Write("Soma: {0}", soma);
                Console.Write("\nQuociente: {0}", quociente);
                Console.Write("\nProduto: {0}", produto);
            }
            Console.ReadLine();
        }
    }
}
// Fazer um algoritmo para ler dois valores reais do teclado, calcular e imprimir na tela:
// a) A soma destes valores   b) O produto deles    c) O quociente entre eles.}
