using System;

namespace Ejercicio_extra2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calcular la serie de fibonacci de un numero
            int n, a = 0, b = 1, c = 1;
            Console.WriteLine("Ingrese un numero de elementos...");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("serie de fibonacci");
            for (int i = 1; i < n; i++)
            {
                c = a + b;
                Console.WriteLine(" " + c);
                a = b;
                b = c;
            }
            Console.ReadKey();

        }
    }
}
