using System;

namespace Ejercicio1_146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que muestre la tabla de multiplicar del 1 al 10
            //de cualquier numero
            byte n, i;
            Console.WriteLine("Ingresa el numero de la tabla de multiplicar que deseas");
            n = byte.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", n, i, (n * i));

            }
            Console.ReadKey();
        }
    }
}

