using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico_Dois
{
    class InvestimentoComIR : Investimento
    {
        public InvestimentoComIR(double valorInicial, double jurosMensais) : base(valorInicial, jurosMensais)
        {
        }

        public override double CalcularLucro(int meses)
        {
            double lucroBruto = 0;
            double lucroLiquido = 0;
            double desconto = 0;
            double impostoRenda = 0;

            if(meses < 6)
            {
                impostoRenda = 0.225;
            }
            if(meses >= 6 & meses < 12)
            {
                impostoRenda = 0.20;
            }
            if(meses >= 12 & meses < 24)
            {
                impostoRenda = 0.175;
            }
            if(meses >= 24)
            {
                impostoRenda = 0.15;
            }

            double expre1 = (1 + JurosMensais);
            double expre2 = Math.Pow(expre1, meses);
            double expre3 = (ValorInicial * expre2);
            lucroBruto = (expre3 - ValorInicial);

            desconto = lucroBruto * impostoRenda;
            lucroLiquido = lucroBruto - desconto;
            return lucroLiquido;
        }
    }
}
