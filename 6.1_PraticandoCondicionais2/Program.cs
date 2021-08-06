using System;

namespace _6._1_PraticandoCondicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeJoao = 17;
            int acompanhante = 1;
            bool acompanhado = acompanhante >= 2;
            //bool acompanhado = true;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine("SEJA BEM VINDO!!!");
            }
            else
            {
             Console.WriteLine("João não pode entrar, volte para casa e vai estudar!");
            }

            Console.ReadLine();
        }
    }

}
