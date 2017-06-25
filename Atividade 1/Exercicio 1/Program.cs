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
            double aplicacao = 0;
            double rendimentoMensal = 0;
            double retorno = 0;
            int mesesAplicacao = 0, tipoJuros;

            Console.Write("Valor a ser aplicado: ");
            aplicacao = double.Parse(Console.ReadLine());
            Console.Write("\nRendimento mensal da poupança em %: ");
            rendimentoMensal = double.Parse(Console.ReadLine());
            Console.Write("\nMeses de aplicação: ");
            mesesAplicacao = int.Parse(Console.ReadLine());
            Console.Write("\nTipo de juros: \n1 - Simples. \n2 - Composto");
            tipoJuros = int.Parse(Console.ReadLine());

            rendimentoMensal = rendimentoMensal / 100;

            switch (tipoJuros)
            {
                case 1://Juros Simples
                    retorno = ((aplicacao * rendimentoMensal) * mesesAplicacao) + aplicacao;
                    Console.Write("Ao final do investimento, vcê terá {0}", retorno);
                    break;

                case 2://Juros Compostos
                    retorno = 
                    Console.WriteLine("Case 2");
                    break;
            }

            }
    }
}
