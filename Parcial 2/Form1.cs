using Clase8.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase8
{
    public partial class Form1 : Form
    {

        private string[] ArregloNotas;
        int[] notaMayor_Parcial1, notaMayor_Parcial2, notaMayor_Parcial3;
        int[] notaMenor_Parcial1, notaMenor_Parcial2, notaMenor_Parcial3;

        public Form1()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    string[] arreglo = new string[5];
        //    arreglo[0] = "Zepeda";
        //    arreglo[1] = "calderas"; 
        //    arreglo[2] = "Maria"; 
        //    arreglo[3] = "Antonio"; 
        //    arreglo[4] = "Jesus";

        //    ClsArreglos ObjetoArreglo = new ClsArreglos(arreglo);
        //    string[] resultado = ObjetoArreglo.MetodoBurbujaNombres();


        //   foreach(string  r in arreglo)
        //    {
        //        string[] linea = r.Split(',');
        //        listBoxResultado.Items.Add(r);
        //    }

        //}

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog(); // esta variable sirve para abrir una ventana 

            ofd.Title = "Selecciona tu archivo plano que deseas";
            ofd.InitialDirectory = @"C:\Users\PC\Videos\AP";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;//devuelve ubicacion y el nombre del archivo
                string resutado = ar.LeerTodoArchivo(archivo);//devuelve todo las lineas del archivo
                ArregloNotas = ar.LeerArchivo(archivo);//devuelve un arreglo
                textBoxResultado.Text = resutado;
            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            int contador = 0;
            string[] ordenar = new string[ArregloNotas.Length - 1];

            foreach (string Linea in ArregloNotas)
            {
                if (contador != 0)
                {

                    string[] datos = Linea.Split(',');
                    ordenar[contador - 1] = datos[1];
                }
                contador++;
            }

            ClsArreglos ObjArreglo = new ClsArreglos(ordenar);
            string[] resultado = ObjArreglo.MetodoBurbuja_Nom();
            for (int i = 0; i < resultado.Length; i++)
            {
                listBoxResultado.Items.Add(resultado[i]);
            }

        }


        private void buttonParcial_Click_1(object sender, EventArgs e)
        {
            {

                int contador = 0;
                int[] notasParcial1 = new int[ArregloNotas.Length - 1];
                int[] notasParcial2 = new int[ArregloNotas.Length - 1];
                int[] notasParcial3 = new int[ArregloNotas.Length - 1];
                int[] notasParcial4 = new int[ArregloNotas.Length - 1];
                int[] notasParcial5 = new int[ArregloNotas.Length - 1];
                int[] notasParcial6 = new int[ArregloNotas.Length - 1];


                foreach (string Linea in ArregloNotas)
                {
                    if (contador != 0)
                    {
                        string[] datos = Linea.Split(',');
                        notasParcial1[contador - 1] = int.Parse(datos[Columnas.Parcial1]);
                        notasParcial2[contador - 1] = int.Parse(datos[Columnas.Parcial2]);
                        notasParcial3[contador - 1] = int.Parse(datos[Columnas.Parcial3]);
                        notasParcial4[contador - 1] = int.Parse(datos[Columnas.Parcial1]);
                        notasParcial5[contador - 1] = int.Parse(datos[Columnas.Parcial2]);
                        notasParcial6[contador - 1] = int.Parse(datos[Columnas.Parcial3]);
                    }
                    contador++;
                }
                ClsArreglos objNotas1 = new ClsArreglos(notasParcial1);
                ClsArreglos objNotas2 = new ClsArreglos(notasParcial2);
                ClsArreglos objNotas3 = new ClsArreglos(notasParcial3);
                ClsArreglos objNotas4 = new ClsArreglos(notasParcial4);
                ClsArreglos objNotas5 = new ClsArreglos(notasParcial5);
                ClsArreglos objNotas6 = new ClsArreglos(notasParcial6);

                notaMayor_Parcial1 = objNotas1.notaMayor_P1();
                notaMayor_Parcial2 = objNotas2.notaMayor_P2();
                notaMayor_Parcial3 = objNotas3.notaMayor_P3();
                notaMenor_Parcial1 = objNotas4.notaMenor_P1();
                notaMenor_Parcial2 = objNotas5.notaMenor_P2();
                notaMenor_Parcial3 = objNotas6.notaMenor_P3();

                int notamin1, notamin2, notamin3, notamax1, notamax2, notamax3;

                notamax1 = notaMayor_Parcial1[0];
                notamax2 = notaMayor_Parcial2[0];
                notamax3 = notaMayor_Parcial3[0];
                notamin1 = notaMenor_Parcial1[0];
                notamin2 = notaMenor_Parcial2[0];
                notamin3 = notaMenor_Parcial3[0];
                MessageBox.Show($"La nota mayor del Parcial1 es: {notamax1}\n La nota menor del Parcial1 es: {notamin1}\n\n La nota mayor del Parcial2 es: {notamax2}\n La nota menor del Parcial 2 es: {notamin2}\n\n La nota mayor del Parcial3 es: {notamax3}\n La nota menor del Parcial3 es: {notamin3}");
            }
        }
        private int Fpromedio(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = acumulador / (totalFilas - 1);
            return promedio;

        }
        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            string[,] Arreglo2D = new string[ArregloNotas.Length, 5];

            int NumLinea = 0;
            foreach (string Linea in ArregloNotas)

            {
                string[] datosUnitarios = Linea.Split(',');
                Arreglo2D[NumLinea, Columnas.Correlativo] = datosUnitarios[0];
                Arreglo2D[NumLinea, Columnas.Nombre] = datosUnitarios[1];
                Arreglo2D[NumLinea, Columnas.Parcial1] = datosUnitarios[2];
                Arreglo2D[NumLinea, Columnas.Parcial2] = datosUnitarios[3];
                Arreglo2D[NumLinea, Columnas.Parcial3] = datosUnitarios[4];

                NumLinea++;

            }
            int promedio = Fpromedio(Arreglo2D, Columnas.Parcial1);
            MessageBox.Show($"El promedio todos los alumnos del parcial 1 que equivale a 10 pts es de {promedio}pts.");
            int promedio2 = Fpromedio(Arreglo2D, Columnas.Parcial2);
            MessageBox.Show($"El promedio del parcial 2 que equivale a 20 pts es de {promedio2}pts.");
            int promedio3 = Fpromedio(Arreglo2D, Columnas.Parcial3);
            MessageBox.Show($"El promedio del parcial 3 que equivale a 40 pts es de {promedio3}pts.");
        
        }
    }
}
