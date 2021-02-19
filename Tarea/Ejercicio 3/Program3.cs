//3.Un obrero necesita calcular su salario semanal, el cual se obtiene de la siguiente manera: 
//Si trabaja 40 horas o menos se le paga Q16 por hora .
//Si trabaja mas de 40 horas se le paga Q16 por cada una de las primeras 40 horas y Q20 por cada hora extra
using System;

namespace Ejercicio_3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int hrs_tra, hrs_ext, salario_s;

            Console.WriteLine("Ingrese las horas trabajadas:\n ");
            hrs_tra = int.Parse(Console.ReadLine());

            if (hrs_tra > 40)
            {
                hrs_ext = hrs_tra - 40;
                salario_s = hrs_ext * 20 + 40 * 16;
            }
            else
            {
                salario_s = hrs_tra * 16;
            }

            Console.WriteLine("El salario semanal es   Q. " + salario_s);

        }
    }
}
