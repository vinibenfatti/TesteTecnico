using System;
using System.Collections.Generic;
using System.Text;

namespace TesteTecnico_Dois
{
    class Investimento
    {
        public double ValorInicial { get; set; }
        public double JurosMensais { get; set; }
        public Investimento(double valorInicial, double jurosMensais)
        {
            this.ValorInicial = valorInicial;
            this.JurosMensais = jurosMensais/100;
        }

        public virtual double CalcularLucro(int meses)
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
