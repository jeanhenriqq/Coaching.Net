using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;
            float notaNecessaria;
            Console.Write("Nota do 1º bimestre: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("\nNota do 2º bimestre: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("\nNota do 3º bimestre: ");
            c = float.Parse(Console.ReadLine());

            notaNecessaria = ((a + b + c));

            if(notaNecessaria >= 70)
            {
                Console.Write("O aluno já passou.");
            }
            else
            {
                notaNecessaria = 70 - notaNecessaria; 
                Console.Write("Faltam {0} pontos para passar.", notaNecessaria);
            }
            Console.ReadLine();
        }
    }
}// Calcular a nota necessária para passar por média no 4º bimestre. Dados: notas dos 3 bimestres (media 70).
