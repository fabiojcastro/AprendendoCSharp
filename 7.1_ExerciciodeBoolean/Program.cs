﻿using System;

namespace _7._1_ExerciciodeBoolean
{
    class Program
    {
        static void Main(string[] args)
        {
            bool foiPromovido = true;
            double salario;

            if (foiPromovido)
            {
                salario = 4200.0;
            }
            else
            {
                salario = 3800.0;
            }

            Console.WriteLine(salario);
            Console.ReadLine();
        }

    }
}