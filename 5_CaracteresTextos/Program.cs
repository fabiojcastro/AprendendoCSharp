using System;

namespace _5_CaracteresTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 Caracteres e Textos");

            char primeiraletra = 'F';
            Console.WriteLine(primeiraletra);

            // char entende números como caracteres ASCII.
            primeiraletra = (char)61;
            Console.WriteLine(primeiraletra);

            primeiraletra = (char)(primeiraletra + 1);
            Console.WriteLine(primeiraletra);

            string titulo = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(titulo);

            Console.ReadLine();
        }
    }
}
