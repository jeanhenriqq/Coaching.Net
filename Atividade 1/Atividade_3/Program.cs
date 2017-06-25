using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double anos, cigarrosDia;
            double preco, gasto;

            Console.Write("A quantos anos fuma: ");
            anos = double.Parse(Console.ReadLine());
            Console.Write("Cigarros fumados por dia: ");
            cigarrosDia = double.Parse(Console.ReadLine());
            Console.Write("Preço da carteira: ");
            preco = double.Parse(Console.ReadLine());          

            gasto = ( anos * 365 * cigarrosDia / 20 *preco);
            Console.Write("Você gastou cerca de : R$ {0}", gasto);
            Console.ReadLine();
        }
    }
}// Calcular a quantidade de dinheiro gasta por um fumante. Dados: o número de 
// anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

