using System;

namespace Ejercicio3
{
    class Program
    {
        public static string generaLetra(int min, int max)
        {
            //random sirve para generar numeros aleatorios
            Random ran = new Random();//crea numeros
            int Num = Convert.ToInt32(ran.Next(96, 123));//le decimos que nos genere un numero aleatorio y que nos convierta en entero
            string LetraRespuesta = "";
            if (((Num > min) & (Num < max)))
            {
                LetraRespuesta = Convert.ToString((char)Num);

            }
            return LetraRespuesta;
        }
        static void Main(string[] args)
        {
            byte Can, K;

            string Linea;
            Console.Write("Cuantos Numeros?");
            Linea = Console.ReadLine();
            Can = byte.Parse(Linea);


            string Letra = "";

            for (K = 1; K <= Can; K++)
            {
                Letra = generaLetra(96, 123);
                Console.WriteLine($"letra generada={Letra}");
            }

        }
    }
}


