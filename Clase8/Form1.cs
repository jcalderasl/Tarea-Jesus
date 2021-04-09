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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 3;
            arreglo[1] = 1; 
            arreglo[2] = 4; 
            arreglo[3] = 2; 
            arreglo[4] = 5;

            ClsArreglos ObjetoArreglo = new ClsArreglos(arreglo);
            int[] resultado = ObjetoArreglo.MetodoBurbuja();

          
           foreach(int  r in arreglo)
            {
                
                listBoxResultado.Items.Add(r);
            }

        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog(); // esta variable sirve para abrir una ventana 

            ofd.Title = "Selecciona tu archivo plano que deseas";
            ofd.InitialDirectory = @"C:\Users\PC\Videos\AP";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;//devuelve ubicacion y el nombre del archivo
                string resutado = ar.LeerTodoArchivo(archivo);//devuelve todo las lineas del archivo
                ArregloNotas = ar.LeerArchivo(archivo);//devuelve un arreglo
                textBoxResultado.Text = resutado;

            }
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(',');
                listBoxResultado.Items.Add($"Nombre de Alumno: {datosUnitarios[1]}");

            }
        }

        private void buttonParcial_Click_1(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)

            {
                string[] datosUnitarios = Linea.Split(',');
                listBoxResultado.Items.Add($"Correlativo:{datosUnitarios[0]} P1: {datosUnitarios[2]} P2: {datosUnitarios[3]} P3: {datosUnitarios[4]}");
            }

        }

        private void buttonPromedio_Click(object sender, EventArgs e)
        {
            foreach (string Linea in ArregloNotas)
            {
                string[] datosUnitarios = Linea.Split(',');
                listBoxResultado.Items.Add($" Alumno: {datosUnitarios[1]} Promedio {datosUnitarios[5]}");

            }

        }
    }
}
