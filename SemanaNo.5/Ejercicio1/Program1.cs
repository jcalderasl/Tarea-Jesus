using System;
using System.Threading;

namespace Tarea5
{
    class Program
    {
        //creamos la funcion y va a devolver un tipo string
        public static string Mid(string parametro, int starIndex, int lenght)
        {
            string result = parametro.Substring(starIndex, lenght);
            return result;//return es para devolver un valor
        }
        static void Main(string[] args)
        {
            string Nombre;
            string Car_mover;
            int K = 0;
            int P = 0;
            int No_decar = 0;
            int U = 0;

            Console.Write("Ingrese su Nombre: ");
            Nombre = Console.ReadLine();
            //mueve o posiciona el cursor en la columna y fila que le indiquemos
            Console.SetCursorPosition(10, 10);
            Console.Write(Nombre);
            //Length cuenta el numero de caracteres de la cadena
            No_decar = Nombre.Length;//cuenta el numero de caracteres del nombre
            U = 70;
            //ToUpper toma un caracter y lo devuelve en mayuscula
            Nombre = Nombre.ToUpper();
            for (P = Nombre.Length; P >= 1; P--)
            {
                //llama a una funcion              
                Car_mover = Mid(Nombre, P - 5, 2);//le indicamos si cuantas letras queremos que mueva 
                for (K = No_decar; K <= U; K++)
                {
                    Console.SetCursorPosition(K, 15);//le indicamos en que fila queremos que las pase a mayusculas
                    Console.Write(" " + Car_mover);
                    //indicamos que haga una pausa a la hora de pasarlo a mayuscula
                    Thread.Sleep(50);
                }
                U = U - 1;
                No_decar = No_decar - 1;
            }
        }
    }
}

