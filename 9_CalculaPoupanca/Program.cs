using System;

namespace _9_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 Praticando contadores");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mes, você terá R$ " + valorInvestido + ".");
                contadorMes ++;
            }
            Console.ReadLine();
        }
    }
}
