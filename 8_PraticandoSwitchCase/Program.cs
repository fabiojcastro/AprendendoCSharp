using System;

namespace _8_PraticandoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 1;

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro");
                    break;

                case 2:
                    Console.WriteLine("Fevereiro");
                    break;

                case 3:
                    Console.WriteLine("Março");
                    break;

                case 4:
                    Console.WriteLine("Abril");
                    break;

                default:
                    Console.WriteLine("Mês não encontrado");
                    break;
            }
            Console.ReadLine();
        }
    }
}
