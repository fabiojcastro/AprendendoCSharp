using System;

namespace _7._2_ExerciciodeAliquota
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 2801.01;

            if (salario >= 1900.0 && salario <= 2800)
                Console.WriteLine("O Imposto de Renda será de 7,5% e será deduzido o valor de R$ 142,00");

            if (salario > 2800.00 && salario <= 3751.0)
                Console.WriteLine("O imposto de Renda será de 15% e será deduzido o valor de R$ 350,00");

            if (salario > 3750.0 && salario <= 4664.0)
                Console.WriteLine("O Imposto de Renda será de 22.5% e será deduzido o valor de R$ 636,00");

            Console.ReadLine();

        }
    }
}
