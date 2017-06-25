using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, total;
            a = 8;
            b = 9;
            c = 7;
            total = (a + b + c) / 3;
            Console.Write("{0} + {1} + {2} \n_________  = {3}\n    3", a, b, c, total);
            Console.ReadKey();
        }
    }
}
