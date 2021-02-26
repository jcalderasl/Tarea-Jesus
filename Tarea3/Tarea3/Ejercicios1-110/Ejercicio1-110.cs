using System;

namespace Ejercicios1_110
{
    class Program
    {
        static void Main(string[] args)
        {

            //Progrma que le pida al usuario un numero y la computadora responda si es par o impar...
            int num = 0;
            Console.WriteLine("Ingrese un Numero: ");
            num= Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El Número es Par");
            }
            else
            {
                Console.WriteLine("El Número es Impar");
            }
        }
    }
}
