using System;

namespace Ejercicio5_110
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, seleccion,d;
            double medida, apotema, area, P = 0;
            short L;

            Console.WriteLine("Ingrese nombre del poligono regular");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese lados del poligono regular");
            L = short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la medida de los lados");
            medida = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese apotema");
            apotema = short.Parse(Console.ReadLine());

            do { 
            Console.WriteLine("Selecciona que desea calcular");
            Console.WriteLine("1 - Perimetro, 2 - Area ");
            seleccion = Console.ReadLine();

            if (seleccion == "1")
            {
                P = L * medida;
                Console.WriteLine("El Perimetro es de: " + P);
            }
            if (seleccion == "2")
            {
                area = (apotema * (L * medida)) / 2;
                Console.WriteLine("EL Area es de: " + area);
            }
                Console.WriteLine("Desea calcular otra opcion...- si - no");
                d = Console.ReadLine();
            } while (d != "no");

        }
    }
}


