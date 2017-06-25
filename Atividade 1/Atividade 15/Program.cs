using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_15
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Digite um nome: ");
            name = Console.ReadLine();
            Console.Write("\nPrimeiro caractere: {0}", name.Substring(0,1));
            Console.Write("\nUltimo caractere: {0}", name.Substring(name.Length -1, 1));
            Console.Write("\nDo primeiro ate o terceiro: {0}",name.Substring(0,3));
            Console.Write("\nQuarto caractere: {0}",name.Substring(3, 1));
            Console.Write("\nTodos menos o primeiro: {0}",name.Substring(1));
            Console.Write("\nOs dois ultimos: {0}", name.Substring(name.Length -2, 2));
            Console.ReadLine();
        }
    }
}
