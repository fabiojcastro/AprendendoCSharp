using System;

namespace _3_VariaveisFlutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo a lidar com pontos flutuantes.");

            double salario, semanal;

            salario = 2500.70;

            semanal = salario / 4;
                Console.WriteLine(salario);

            Console.WriteLine("Meu pagamento semanal é de " + semanal);

            Console.ReadLine();
        }
    }
}
