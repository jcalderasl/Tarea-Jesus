using System;
using System.Collections.Generic;
using System.Text;

namespace Clase8.clases
{
    class ClsArreglos
    {
        private int[] ArregloTemporal;
        private int[] datos;
        private int i, j, datosTemporal;
        private int tamanoArreglo = 0;
        private string[] arreglo;

        public int GetTamanoArreglo()
        {
            return datos.Length;
        }

        public ClsArreglos(int[] arregloParametro)
        {
            datos = arregloParametro;
            tamanoArreglo = datos.Length;
        }

        public ClsArreglos(string[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public int[] MetodoBurbuja()
        {
            ArregloTemporal = datos;
            for(i=0; i<tamanoArreglo-1; i++)
            {
                for (j = i+1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i] > ArregloTemporal[j])
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
            }
            return ArregloTemporal;
        }


    }
}
