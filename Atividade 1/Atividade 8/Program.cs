using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, adress, telephone;
            Console.Write("Nome: ");
            name = Console.ReadLine();
            Console.Write("\nEndereço: ");
            adress = Console.ReadLine();
            Console.Write("\nTelefone: ");
            telephone = Console.ReadLine();
            Console.Clear();
            Console.Write("Nome: {0} \nEndereço: {1} \nTelefone: {2}", name, adress, telephone);
            Console.ReadKey();
        }
    }
}
