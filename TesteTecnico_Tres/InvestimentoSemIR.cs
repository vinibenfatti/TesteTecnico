using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico_Dois
{
    class InvestimentoSemIR : Investimento
    {
        public InvestimentoSemIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }

        public override double CalcularLucro(int meses)
        {

            if (ValorInicial < 1000)
            {
                Console.WriteLine("O valor Inicial não pode ser menor que R$1000");
                return 0;
            }
            else
            {
                double lucro = 0;
                double expre1 = (1 + JurosMensais);
                double expre2 = Math.Pow(expre1, meses);
                double expre3 = (ValorInicial * expre2);
                lucro = expre3 - ValorInicial;
                return lucro;
            }
        }

    }
}
