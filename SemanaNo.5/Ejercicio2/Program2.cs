using System;
using System.Threading;

namespace Ejercicio2
{
    class Program
    {
        //void es cuando no vamos a devolver un valor
        public static void dibuja(int Cantidad)
        {
            int Fila = 10;
            int Columna = 10;
            int Fila2 = 0;
            int Columna2 = 0;
            int A, B, C;

            for (C = 1; C <= Cantidad; C++)
            {
                for (A = Columna2; A <= Columna; A++)
                {
                    //mueve o posiciona el curso en la fila y columna que le indiquemos
                    Console.SetCursorPosition(A, Fila); Console.Write("-");//fila de abajo
                    Console.SetCursorPosition(A, Fila2); Console.Write("O");//fila de arriba
                }
                for (B = Fila2; B <= Fila; B++)
                {
                    Console.SetCursorPosition(Columna2, B); Console.Write("/");//columna izquierda
                    Console.SetCursorPosition(Columna, B); Console.Write("X");//columna derecha
                }
                Fila2++;
                Fila--;
                Columna2++;
                Columna--;

            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam <= 3; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}

