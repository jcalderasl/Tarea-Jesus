using System;

namespace Ejercicio2_110
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que tranforme de grados a radianes o de radianes a grados 
            //dependiendo de lo que necesite el usuario 
            double angulo = 0;
            double pi = 3.1416;
            double radianes = 0;
            double grados = 0;
            string seleccion;
            string valor;

            Console.WriteLine("1 - radianes a grados, 2 - grados a radianes ");
            seleccion = Console.ReadLine();

            Console.WriteLine("Ingrese el Angulo a convertir: ");
            valor = Console.ReadLine();
            angulo = Convert.ToDouble(valor);

            if (seleccion == "1")
            {
                grados = angulo * (180 / pi);
                Console.WriteLine("{0} radianes es {1}grados", angulo, grados);
            }
            if (seleccion == "2")
            {
                radianes = angulo * (pi / 180);
                Console.WriteLine("{0}grados es {1} radianes", angulo, radianes);
            }

        }
    }
}
