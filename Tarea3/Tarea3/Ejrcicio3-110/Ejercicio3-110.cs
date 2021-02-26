using System;

namespace Ejrcicio3_110
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que calcule el impuesto de un producto. Pero coloque 
            //un impuesto de 0%si el producto es medicina.
            double medicamentos = 0;
            double abarrotes = 0;
            string seleccion;
            double precio;
            string nombre;

            Console.WriteLine("Selecciona que clase de producto compro");
            Console.WriteLine("1 - Abarrotes y otros , 2 - Medicamentos ");
            seleccion = Console.ReadLine();

            Console.WriteLine("Ingrese nombre del producto: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el Precio del producto: ");
            precio = double.Parse(Console.ReadLine());

            if (seleccion == "1")
            {
                abarrotes = precio * 0.12;
                Console.WriteLine("El impuesto de la compra es de Q. {1}", precio, abarrotes);
            }
            if (seleccion == "2")
            {
                medicamentos = precio * 0;
                Console.WriteLine("EL impuesto de la compra es de   Q. {1}", precio, medicamentos);
            }

        }
    }
}


