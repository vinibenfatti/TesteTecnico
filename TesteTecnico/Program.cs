using System;

namespace TesteTecnico_Um
{
    class Program
    {
        static void Main(string[] args)
        {
            int numUser = 0;
            int numUserTot = 0;

            while (numUserTot < 300)
            {
                Console.WriteLine("Digite um número positivo:");
                numUser = int.Parse(Console.ReadLine());
                if(numUser >= 0)
                {
                    numUserTot= numUserTot + numUser;
                }
                else
                {
                    Console.WriteLine("Números negativos não são permitidos");
                }
            } 

            Console.WriteLine("O somátório foi: " + numUserTot);
            Console.ReadKey();
            Environment.Exit(0);

        }
    }
}
