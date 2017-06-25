using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double saldoAnterior = 0.0;
            double reajuste = 1;
            double saldoReajustado = 0.0; 
            Console.Write("Digite o saldo da aplicação: ");
            saldoAnterior = double.Parse(Console.ReadLine());
            saldoReajustado = (saldoAnterior * (reajuste/100)) + saldoAnterior;
            Console.Write("O novo saldo é de: {0:#.00}", saldoReajustado);
            Console.ReadLine();
        }
    }
}
