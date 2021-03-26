using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Tarea6.Clases
{
    class ClsAutoMotor
    {
        public String marca { get; }//get=cuando se lee la p. set=asignar
        public int vel_Max { get; }

        private int vel_Actual = 0;
  
        public bool encendido { get; set; } = false;

        public ClsAutoMotor(String marca_car, int MaxVel)
        {
            this.vel_Max = MaxVel;
            this.marca = marca_car;
        }


        public string encender()
        {
            string respuesta = "";
            if (encendido)
            {
                encendido = false;
                respuesta = " Ahora el carro está apagado.";
            }

            {
                encendido = true;
                respuesta = "Auto encendido...";
            }
            vel_Actual = 0;
            return respuesta;
        }

        public string DetenerMarcha()
        {
            if (!encendido)
            {
                return "EL carro no esta encendido, tienes que encenderlo primero.";
            }
            vel_Actual = 0;
            return "Auto Detenido.";
        }


        public string Acelerar()
        {
            if (!encendido)
            {
                return "EL carro no esta encendido, tienes que encenderlo primero.";
            }
            if (vel_Actual == vel_Max)
            {
                vel_Actual = vel_Max;
                return $"ALTO, ALTO, ya has llegado a la velocidad Maxima de {vel_Max}km/h.";
            }
            else
            {
                vel_Actual = vel_Actual + 5;

            }

            if (vel_Actual == 20)
            {
                return $"Vas a {vel_Actual} km/h, Cambia a 2da. Marcha  ";
            }
            if (vel_Actual == 30)
            {
                return $"Vas a {vel_Actual} km/h, Cambia a 3ra. Marcha  ";
            }
            if (vel_Actual == 40)
            {
                return $"Vas a {vel_Actual} km/h, Cambia a 4ta. Marcha  ";
            }
            if (vel_Actual == 50)
            {
                return $"Vas a {vel_Actual} km/h, Cambia a 5ta. Marcha  ";
            }

            return $"Vas a {vel_Actual} km/h";
        }

        public string Radio()
        {
            if (!encendido)
            {
                return "EL carro no esta encendido, tienes que encenderlo primero.";
            }
            encendido = true;
            return "Lito radio encendida.";
        }
        public string off()
        {
            if (!encendido)
            {
                return "No esta encendida la radio";
            }
            encendido = true;
            return "Radio apagada.";
        }
    }
}
