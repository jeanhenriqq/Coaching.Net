using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            double media;

            Console.Write("Digite a nota do 1º bimestre: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 2º bimestre: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 3º bimestre: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite a nota do 4º bimestre: ");
            d = int.Parse(Console.ReadLine());

            media = (a + b + c + d) / 4;
            Console.WriteLine("Média: {0}", media);
            if(media >= 6)
            {
                Console.Write("O aluno foi aprovado.");
            }
            else
            {
                Console.Write("O aluno foi reprovado.");
            }
            Console.ReadLine();
        }
    }
}//  7.   Calcular a média final  (nota bimestre 1 + bimestre 2 +  bimestre3 dividido por 3 )
 //  dadas as  notas dos 4 bimestres e produzir uma saída com a média e a situação do aluno de
 // acordo com o seguinte critério: média >=6, aprovado; média < 6, reprovado.a
