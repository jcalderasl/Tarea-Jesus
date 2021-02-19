//4 Un año es bisiesto si es divisible por 4  excepto aquellos divisibles por 100 pero no por 400  
using System;

namespace Ejercicio_4
{
    class Program4
    {
        static void Main(string[] args)
        {
            short año;

            Console.WriteLine("Ingrese año");
            año = short.Parse(Console.ReadLine());
            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año {0} es bisiesto", año);
            }

            else
            {
                Console.WriteLine("El año {0} no es bisiesto", año);
            }

            Console.ReadLine();

        }
    }
}

