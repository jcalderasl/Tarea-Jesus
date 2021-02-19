//6 Pide un número por teclado e indica si es un número primo o no. Un número primo es aquel solo puede dividirse entre 1 y si mismo. 
//Por ejemplo: 25 no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.
using System;

namespace Ejercicio_6
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Número");
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            int j = 0;

            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    j++;
                    i = n;
                    i++;
                }
            }
            if (j == 0) { Console.WriteLine("\nEl Número es primo"); }
            else { Console.WriteLine("\nEl Número no es primo "); }
            Console.Read();

        }
    }
}
