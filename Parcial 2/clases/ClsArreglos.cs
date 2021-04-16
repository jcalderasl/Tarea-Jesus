using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Clase8.clases
{
    class ClsArreglos
    {
        private string[] ArregloTemporal;
        private string[] datos;
        private int i, j;
        private string datoTemporal;

        public ClsArreglos(string[] arreglo)
        {
            datos = arreglo;

        }

        public string[] MetodoBurbuja_Nom()
        {
            ArregloTemporal = datos;

            for (i = 0; i < datos.Length - 1; i++)
            {
                for (j = i + 1; j < datos.Length; j++)
                {
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datoTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datoTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }
        private int[] datos1;

        public ClsArreglos(int[]arreglo)
        {
            datos1 = arreglo;
        }
        private int[] ArregloTemporal1;
        private int x, y;
        private int datosTemporal1;

        public int[] notaMayor_P1()
        {
            ArregloTemporal1 = datos1;

            for (x = 0; x < datos1.Length - 1; x++)
            {
                for (y = x + 1; y < datos1.Length; y++)
                {
                    if (ArregloTemporal1[x] < ArregloTemporal1[y])
                    {
                        datosTemporal1 = ArregloTemporal1[x];
                        ArregloTemporal1[x] = ArregloTemporal1[y];
                        ArregloTemporal1[y] = datosTemporal1;
                    }
                }
            }

            return ArregloTemporal1;
        }


        private int[] ArregloTemporal2;
        private int a, b;
        private int datoTemporal2;

        public int[] notaMayor_P2()
        {
            ArregloTemporal2 = datos1;
            for (a = 0; a < datos1.Length; a++)
            {
                datoTemporal2 = ArregloTemporal2[a];
                b = a - 1;
                while (b >= 0 && ArregloTemporal2[b] < datoTemporal2)
                {
                    ArregloTemporal2[b + 1] = ArregloTemporal2[b];
                    b--;
                }
                ArregloTemporal2[b + 1] = datoTemporal2;
            }
            return ArregloTemporal2;
        }

        private int[] ArregloTemporal3;
        private int c, d, min;
        private int datoTemporal3;

        public int[] notaMayor_P3()
        {
            ArregloTemporal3 = datos1;
            for (c = 0; c < datos1.Length; c++)
            {
                min = c;
                for (d = c + 1; d < datos1.Length; d++)
                {
                    if (ArregloTemporal3[min] < ArregloTemporal3[d])
                    {
                        min = d;
                    }
                }
                datoTemporal3 = ArregloTemporal3[c];
                ArregloTemporal3[c] = ArregloTemporal3[min];
                ArregloTemporal3[min] = datoTemporal3;
            }
            return ArregloTemporal3;
        }
        public int[] notaMenor_P1()
        {
            ArregloTemporal3 = datos1;
            for (c = 0; c < datos1.Length; c++)
            {
                min = c;
                for (d = c + 1; d < datos1.Length; d++)
                {
                    if (ArregloTemporal3[min] > ArregloTemporal3[d])
                    {
                        min = d;
                    }
                }
                datoTemporal3 = ArregloTemporal3[c];
                ArregloTemporal3[c] = ArregloTemporal3[min];
                ArregloTemporal3[min] = datoTemporal3;
            }
            return ArregloTemporal3;
        }
        public int[] notaMenor_P2()
        {
            ArregloTemporal3 = datos1;
            for (c = 0; c < datos1.Length; c++)
            {
                min = c;
                for (d = c + 1; d < datos1.Length; d++)
                {
                    if (ArregloTemporal3[min] > ArregloTemporal3[d])
                    {
                        min = d;
                    }
                }
                datoTemporal3 = ArregloTemporal3[c];
                ArregloTemporal3[c] = ArregloTemporal3[min];
                ArregloTemporal3[min] = datoTemporal3;
            }
            return ArregloTemporal3;
        }
        public int[] notaMenor_P3()
        {
            ArregloTemporal3 = datos1;
            for (c = 0; c < datos1.Length; c++)
            {
                min = c;
                for (d = c + 1; d < datos1.Length; d++)
                {
                    if (ArregloTemporal3[min] > ArregloTemporal3[d])
                    {
                        min = d;
                    }
                }
                datoTemporal3 = ArregloTemporal3[c];
                ArregloTemporal3[c] = ArregloTemporal3[min];
                ArregloTemporal3[min] = datoTemporal3;
            }
            return ArregloTemporal3;
        }
    }
}
//class ClsArreglos
//{
//private int[] ArregloTemporal;
//private int[] datos;
//private int i, j, datosTemporal;
//private int tamanoArreglo = 0;
//private string[] arreglo;

//public int GetTamanoArreglo()
//{
//    return datos.Length;
//}

//public ClsArreglos(int[] arregloParametro)
//{
//    datos = arregloParametro;
//    tamanoArreglo = datos.Length;
//}

//public ClsArreglos(string[] arreglo)
//{
//    this.arreglo = arreglo;
//}

//public int[] MetodoBurbuja()
//{
//    ArregloTemporal = datos;
//    for(i=0; i<tamanoArreglo-1; i++)
//    {
//        for (j = i+1; j < tamanoArreglo; j++)
//        {
//            if (ArregloTemporal[i] > ArregloTemporal[j])
//            {
//                datosTemporal = ArregloTemporal[i];
//                ArregloTemporal[i] = ArregloTemporal[j];
//                ArregloTemporal[j] = datosTemporal;
//            }
//        }
//    }
//    return ArregloTemporal;
//}