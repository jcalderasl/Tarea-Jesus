using System;
using System.Threading;

namespace Ejercicio2
{
    class Program
    {
        //void es cuando no vamos a devolver un valor
        public static void dibuja(int Cantidad)
        {
            int Lateral = 10;
            int Horizontal = 20;
            int FI = 8;
            int CI = 1;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (F = CI; F <= Horizontal; F++)
                {
                    //mueve o posiciona el curso en la fila y columna que le indiquemos
                    Console.SetCursorPosition(F, Lateral); Console.Write("-");//fila de abajo
                    Console.SetCursorPosition(F, FI); Console.Write("O");//fila de arriba
                }
                for (C = FI; C <= Lateral; C++)
                {
                    Console.SetCursorPosition(CI, C); Console.Write("/");//columna izquierda
                    Console.SetCursorPosition(Horizontal, C); Console.Write("X");//columna derecha
                }
                FI = FI + 1;
                Lateral--;
                CI++;
                Horizontal--;

            }
        }

        static void Main(string[] args)
        {
            for (int tam = 1; tam < 3; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
            Console.ReadKey();
        }
    }
}

