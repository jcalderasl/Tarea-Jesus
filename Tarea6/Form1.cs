using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea6.Clases;

namespace Tarea6
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carro;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            carro = new ClsAutoMotor("", 130);

            MessageBox.Show($"El carro {comboBoxMarca.Text}, color {comboBoxColor.Text}, llega a {carro.vel_Max}km/h");


            buttonAcelerar.Visible = true;
            buttonAltoTotal.Visible = true;
            buttonEncender.Visible = true;
            buttonInicio.Visible = false;
            buttonRadio.Visible = true;
            button1.Visible = true;
            labelEstado.Visible = true;
            labelEstadoVelocidad.Visible = true;
            labelradio.Visible = true;
            
            comboBoxColor.Visible = false;
            comboBoxMarca.Visible = false;

            

        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
         labelEstado.Text = $"El carro {comboBoxMarca.Text}, color {comboBoxColor.Text}, {carro.encender()}";
            
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carro == null)
            {
                MessageBox.Show("Aún no has Creado el carro, crealo primero.");
            }
            else
            {
                labelEstadoVelocidad.Text = carro.Acelerar();

            }

        }


        private void buttonAltoTotal_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carro.DetenerMarcha();
        }

        private void buttonRadio_Click(object sender, EventArgs e)
        {
            if (carro == null)
            {
                MessageBox.Show("Aún no has encendido el carro, tiene que encenderlo.");
            }
            else
            {
                labelradio.Text = carro.Radio();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (carro == null)
            {
                MessageBox.Show("No está encendida la radio.");
            }
            else
            {
                labelradio.Text = carro.off();
            }
    
        }
    }
}
