using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    class Investimento
    {
        public double ValorAplicacao { get; set; }
        public double JurosMes { get; set; }
        public int QuantidadeMeses { get; set; }
        public double RendimentoMensal { get; set; }
        public double RendimentoTotal { get; set; }

        public void ContaPoupanca()
        {
            RendimentoTotal = ValorAplicacao;
            
            for (int i = 1; i < QuantidadeMeses; i++)
            {                
                RendimentoMensal = (RendimentoTotal * JurosMes) / 100;
                RendimentoTotal += RendimentoMensal;
            }

        }
    }
}
