//2.En MegaPlaza se hace un 20% de descuento a los clientes  cuya compra supere los 300.
using System;

namespace Ejercicio_2
{
    class Program2
    {
        static void Main(string[] args)
        {
            double compra, descuento, total;

            Console.WriteLine("Ingrese la cantidad que gasto :  ");
            compra = double.Parse(Console.ReadLine());

            if (compra > 300)
            {
                descuento = compra * 0.20;
            }
            else
            {
                descuento = 0;
            }

            total = compra - descuento;
            Console.WriteLine("El total a pagar es de:  " + total);

        }
    }
}

