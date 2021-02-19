//1.Programa que lea un carácter por teclado y compruebe si es una letra mayúscula
using System;

namespace Ejercicio_1
{
    class Program1
    {
        static void Main(string[] args)
        {
            char car;
            Console.WriteLine("Introduzca un carácter: ");
            car = char.Parse(Console.ReadLine());

            if (Char.IsUpper(car))
            {
                Console.WriteLine("El caracter es una letra MAYUSCULA");
            }
            else
            {
                Console.WriteLine("El caracter no es una letra mayuscula");
            }
        }
    }
}

