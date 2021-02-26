using System;

namespace Ejercicio5_146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcule el promedio de edad de un grupo de 
            //personas y diga cual es la edad mas grande y cual es la mas joven. 
            double ma = 0, me = 0, edad = 0, numeros, prom = 0, s = 0;

            Console.WriteLine("Ingrese numero de personas que desea...");
            numeros = double.Parse(Console.ReadLine());
            for (double i = 1; i <= numeros; i++)
            {
                Console.WriteLine("Ingrese la edad ");
                edad = double.Parse(Console.ReadLine());
                s = s + edad;

                if (i == 1)
                {
                    ma = edad;
                    me = edad;
                }
                if (edad > ma) { ma = edad; }
                if (edad < me) { me = edad; }

            }
            prom = s / numeros;
            Console.WriteLine(" El promedio de edad es de: " + prom);
            Console.WriteLine(" La edad mayor ingresada es de: " + ma);
            Console.WriteLine(" La edad menor ingresada es de: " + me);

        }
    }
}

