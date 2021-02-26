using System;

namespace Ejercicio4_146
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un progrma que encuentre los numeros primos que existen entre el 1 y el 1000.
            short num = 2, div = 0;

            Console.WriteLine("Mostrando Numeros Primos del 1 al 1000\n");
            while (num <= 1000)
            {
                for (short i = 1; i <= num; i++)

                {
                    if (num % i == 0)
                    {
                        div++;
                    }
                    if (div > 2)
                    {
                        break;
                    }
                }
                if (div == 2)
                {
                    Console.WriteLine("{0} es primo", num);
                }
                div = 0;
                num++;
            }

            Console.ReadKey();
        }
    }
}

