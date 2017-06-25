using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, quociente;

            Console.Write("Digite um número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite um número: ");
            b = int.Parse(Console.ReadLine());

            if(b != 0)
            {
                quociente = a / b;
                Console.WriteLine("O quociente é igual a: {0}", quociente);
            }
            else
            {
                Console.Write("Divisão por 0.");
            }
            Console.ReadLine();
        }
    }
}// Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
// calcular e imprimir o quociente do primeiro pelo segundo. Caso 
// contrário, imprimir a mensagem: "DIVISÃO POR ZERO".
