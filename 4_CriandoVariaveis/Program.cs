using System;

namespace _4_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4_Criando_Variaveis");
            
            // int é um tipo de variavel que aceita numeros inteiros até 64 bits.
            int salario = 2800;
            Console.WriteLine(salario);

            // double é um tipo de váriavel que aceita números com casas decimais até 64 bits.
            double distancia = 1200.73;
            Console.WriteLine(distancia);

            //long é um tipo de váriável que aceita números inteiros ate 64 bits;
            long lotes = 15000000;
            Console.WriteLine(lotes);

            //type casting
            int comprimento = (int)distancia;
            Console.WriteLine(comprimento);

            // short é um tipo de variavel que aceita numeros inteiros até 16 bits
            short compras = 15000;
            Console.WriteLine(compras);

            // float é um tipo de váriavel que aceita números decimais até 16 bits
            float altura = 1.70f;
            Console.WriteLine(altura);

            Console.ReadLine();


        }
    }
}
