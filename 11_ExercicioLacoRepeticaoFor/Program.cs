using System;

namespace _11_ExercicioLacoRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 11 - Exercicio de Laço de Repetição com For");


            for (int cont = 1; cont <= 5; cont++)
            {
                //Console.WriteLine(cont);

                for (int cont2 = 1; cont2 <= cont; cont2++)
                {
                    Console.Write(cont2);
                }

                Console.WriteLine();
            }

            for (int multi = 1; multi <= 10; multi++)
            {
                for (int num = 0; num <= 9; num++)
                {
                    int conta = multi * num;
                    Console.WriteLine(+multi + " X " + num + " é " + conta);
                }
                Console.WriteLine();
            }

            int cont3 = 0;
            for (int laco = 1; laco <= 100; laco++)
            {
                if (laco % 3 == 0)
                {
                    Console.WriteLine(" O número " + laco + " é múltiplo de 3.");
                    cont3 = cont3 + 1;
                }
            }
            Console.WriteLine("Existem " + cont3 + " números que são multiplos de 3 entre 1 e 100");

            Console.WriteLine();

            int result = 1;
            int fator2 = 0;
            for (int fator = 1; fator <= 10; fator++)
            {
                for (fator2 = 1; fator2 <= fator; fator2++)
                {
                    if (fator == fator2)
                    {
                        result = result * fator2;
                    }
                }
                Console.WriteLine("O fatorial de " + fator + " é igual a " + result);
            }
            Console.ReadLine();
        }
    }
}
