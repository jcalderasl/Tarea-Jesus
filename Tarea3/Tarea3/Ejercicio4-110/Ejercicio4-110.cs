using System;

namespace Ejercicio4_110
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            //programa que le pida al usuario un numero del 1 al 7 y escribe 
            //el nombre del dia que corresponde a ese numero en la semana
            byte dia;

            Console.WriteLine("Introduce un número del 1 al 7\n");
            dia = Convert.ToByte(Console.ReadLine());

            switch (dia)
            {
                case 1: Console.WriteLine(" El día es Lunes..."); break;
                case 2: Console.WriteLine("El día es Martes..."); break;
                case 3: Console.WriteLine(" El día es Miercoles..."); break;
                case 4: Console.WriteLine("El día es Jueves..."); break;
                case 5: Console.WriteLine(" El día es Viernes..."); break;
                case 6: Console.WriteLine("El día es Sabado..."); break;
                case 7: Console.WriteLine("El día es Domingo..."); break;
                default: Console.WriteLine("Has introducido un numero mayor al 7..."); break;

            }
        }
    }
}
