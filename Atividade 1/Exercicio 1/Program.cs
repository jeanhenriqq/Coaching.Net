using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Investimento investimento = new Investimento();
            
            Console.Write("Valor a ser aplicado: ");
            investimento.ValorAplicacao = double.Parse(Console.ReadLine());
            Console.Write("\nTaxa de juros: ");
            investimento.JurosMes = double.Parse(Console.ReadLine());
            Console.Write("\nMeses de aplicação: ");
            investimento.QuantidadeMeses = int.Parse(Console.ReadLine());

            Console.WriteLine(" \n");
            Console.WriteLine("-------------------------------");

            Console.WriteLine("O retorno do seu investimento total será: {0}", investimento.RendimentoMensal);
            Console.WriteLine(" \n");          
            
            Console.ReadKey();
        }
    }
}
