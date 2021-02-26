using System;

namespace TesteTecnico_Dois
{
    class Program
    {
        static void Main(string[] args)
        {

            InvestimentoComIR investimentoComIR = new InvestimentoComIR(5000, 1.2);
            Console.WriteLine(Math.Round(investimentoComIR.CalcularLucro(17),2));

            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(3000, 0.7);
            Console.WriteLine(Math.Round(investimentoSemIR.CalcularLucro(10),2));

            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
