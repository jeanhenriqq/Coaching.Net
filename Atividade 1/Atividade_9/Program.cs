using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, meuNome = "jean";

            Console.Write("Escreva um nome: ");
            nome = string.Format(Console.ReadLine()).ToLower();

            if(nome == meuNome)
            {
                Console.Write("Nome correto.");
            }
            else{
                Console.WriteLine("Nome incorreto.");
            }
            Console.ReadKey();
        }
    }
}// Ler um nome do teclado e verificar se é igual ao seu nome. Imprimir 
// conforme o caso: " NOME CORRETO "  ou  " NOME INCORRETO ".
