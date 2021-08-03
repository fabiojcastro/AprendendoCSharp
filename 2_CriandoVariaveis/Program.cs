using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Praticando na inserção de variáveis.");
            Console.WriteLine();
            
            int idade;
            
            idade = 29;
            Console.WriteLine(idade);

            idade = 10 + 13;
            Console.WriteLine(idade);

            idade = 10 + 2 * 5;
            Console.WriteLine(idade);

            idade = 50 - 10 / 2;
            Console.WriteLine(idade);
            Console.WriteLine();

            Console.WriteLine("Minha idade é " + idade + " anos!");
            Console.ReadLine();
        }
    }
}
