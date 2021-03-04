using System;

namespace Ejercicio_extra1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcule el factorial de un numero.
            int n, fact = 1, contador = 0;
            Console.WriteLine("Ingrese un numero...");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                contador = contador + 1;
                fact = fact * contador;
            }
            Console.WriteLine("El factorial del numero es de: " + fact);
            Console.ReadKey();

        }
    }
}
