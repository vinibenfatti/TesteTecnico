using System;

namespace TesteTecnico_Dois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor inicial:");
            double valorInicialUser = Convert.ToDouble(Console.ReadLine());

            InvestimentoComIR investimentoComIR = new InvestimentoComIR(valorInicialUser, 0.35);
            InvestimentoSemIR investimentoSemIR = new InvestimentoSemIR(valorInicialUser, 0.3);

            for (int i = 1; i < 36; i++) { 
       
                double lucroIR = Math.Round(investimentoComIR.CalcularLucro(i), 2);
                double lucroSemIR = Math.Round(investimentoSemIR.CalcularLucro(i), 2);

                Console.WriteLine("Mês: " + i + " | Investimento sem IR: " + lucroSemIR + " | Investimento com IR: " + lucroIR);
            }

            Console.ReadKey();
            Environment.Exit(0);






        }
    }
}
