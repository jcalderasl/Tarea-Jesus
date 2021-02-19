//5 Crea una aplicación que nos pida un día de la semana y que nos diga si es un dia laboral o no. Usa un switch para ello.
using System;

namespace Ejercicio_5
{
    class Program5
    {
        static void Main(string[] args)
        {
            string dia;

            Console.WriteLine("Introduce un día de la semana\n");
            dia = Console.ReadLine();

            switch (dia)
            {
                case "Lunes": Console.WriteLine("LUNES es un día laboral..."); break;
                case "Martes": Console.WriteLine("MARTES es un día laboral..."); break;
                case "Miercoles": Console.WriteLine("MIERCOLES es un día laboral..."); break;
                case "Jueves": Console.WriteLine("JUEVES es un día laboral..."); break;
                case "Viernes": Console.WriteLine("VIERNES es un día laboral..."); break;
                case "Sabado": Console.WriteLine("SABADO tienes descanso..."); break;
                case "Domingo": Console.WriteLine("DOMINGO tienes descanso..."); break;
                default: Console.WriteLine("No es un dia"); break;

            }
        }
    }
}
