using System;
using System.Collections.Generic;
using System.Text;

namespace Clase8.clases
{
    interface InterfacePromedios
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columnaParcial"></param>
        /// <returns></returns>
        int promedios_por_parcial(string[,] matriz, int columnaParcial);


        /// <summary>
        /// retorna el promedio de un parcial especial y una seccion epecial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columnaParcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz, int columnaParcial, string seccion);

        /// <summary>
        /// Saca el promedio general de todos los alumnos por seccion
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columanaParcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_general_seccion(string[,] matriz, int columanaParcial, string seccion);

        /// <summary>
        /// Retorna una matriz de 2 columnas con el nombre y la otra columna es la sumatoria del parcial del 1 al 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] ClasificarAlumnos(string[,] matriz, string seccion);

        /// <summary>
        /// busca el mejor promedio general o por seccion 
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>
        string nombreNota_mayor(string[,] matriz);
        string nombreNota_menor(string[,] matriz, string seccion);

    }
}
