using System;

namespace Ejercicio2_146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que calcule el resultado de un numero elevado a cualquier potencia
            int bas, exponenete, i, acum = 1;
            Console.WriteLine("Ingresa la base de la potencia: ");
            bas =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el exponente de la potencia: ");
            exponenete = Convert.ToInt32(Console.ReadLine());
            

            for (i = 1; i <= exponenete; i++)
            {
                acum = acum * bas;
            }
            Console.WriteLine("El resultado es: {0}", acum);
            Console.ReadKey();
        }
    }
}
