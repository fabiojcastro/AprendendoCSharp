using System;

namespace _6_PraticandoCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 6 Praticando Condicional.");

            int idadeJoao = 19;
            int acompanhante = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João é maior de idade, pode entrar.");
                Console.WriteLine("SEJA BEM VINDO!!!");
            }

            else
            {
                if (acompanhante >= 2)
                {
                    Console.WriteLine("João pode entrar pois está acompanhado de um adulto.");
                }
                else
                {
                    Console.WriteLine("João é menor de idade, volte para casa e vai estudar!");


                }
            }

            Console.ReadLine();
        }

    }
}

