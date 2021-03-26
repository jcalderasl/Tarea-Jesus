
using System;

namespace Tarea6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInicio = new System.Windows.Forms.Button();
            this.labelEstado = new System.Windows.Forms.Label();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonAcelerar = new System.Windows.Forms.Button();
            this.labelEstadoVelocidad = new System.Windows.Forms.Label();
            this.buttonAltoTotal = new System.Windows.Forms.Button();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.labelradio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonInicio
            // 
            this.buttonInicio.Location = new System.Drawing.Point(348, 85);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(112, 42);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.Text = "Crear Carro";
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(475, 146);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(70, 15);
            this.labelEstado.TabIndex = 1;
            this.labelEstado.Text = "Inf. del auto";
            this.labelEstado.Visible = false;
            // 
            // buttonEncender
            // 
            this.buttonEncender.Location = new System.Drawing.Point(339, 133);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(130, 40);
            this.buttonEncender.TabIndex = 2;
            this.buttonEncender.Text = "Encender el Carro";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Visible = false;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonAcelerar
            // 
            this.buttonAcelerar.Location = new System.Drawing.Point(339, 309);
            this.buttonAcelerar.Name = "buttonAcelerar";
            this.buttonAcelerar.Size = new System.Drawing.Size(130, 46);
            this.buttonAcelerar.TabIndex = 3;
            this.buttonAcelerar.Text = "Acelerar";
            this.buttonAcelerar.UseVisualStyleBackColor = true;
            this.buttonAcelerar.Visible = false;
            this.buttonAcelerar.Click += new System.EventHandler(this.buttonAcelerar_Click);
            // 
            // labelEstadoVelocidad
            // 
            this.labelEstadoVelocidad.AutoSize = true;
            this.labelEstadoVelocidad.Location = new System.Drawing.Point(500, 325);
            this.labelEstadoVelocidad.Name = "labelEstadoVelocidad";
            this.labelEstadoVelocidad.Size = new System.Drawing.Size(70, 15);
            this.labelEstadoVelocidad.TabIndex = 4;
            this.labelEstadoVelocidad.Text = "Velocidades";
            this.labelEstadoVelocidad.Visible = false;
            this.labelEstadoVelocidad.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAltoTotal
            // 
            this.buttonAltoTotal.Location = new System.Drawing.Point(339, 379);
            this.buttonAltoTotal.Name = "buttonAltoTotal";
            this.buttonAltoTotal.Size = new System.Drawing.Size(130, 46);
            this.buttonAltoTotal.TabIndex = 6;
            this.buttonAltoTotal.Text = "Alto Total";
            this.buttonAltoTotal.UseVisualStyleBackColor = true;
            this.buttonAltoTotal.Visible = false;
            this.buttonAltoTotal.Click += new System.EventHandler(this.buttonAltoTotal_Click);
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Blanco",
            "Rojo",
            "Azul",
            "Negro",
            "Amarillo",
            "Gris"});
            this.comboBoxColor.Location = new System.Drawing.Point(430, 31);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(130, 23);
            this.comboBoxColor.TabIndex = 7;
            this.comboBoxColor.Text = "Escoge Color del Auto";
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(254, 220);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(58, 46);
            this.buttonRadio.TabIndex = 9;
            this.buttonRadio.Text = "On Radio";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Visible = false;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // labelradio
            // 
            this.labelradio.AutoSize = true;
            this.labelradio.Location = new System.Drawing.Point(384, 193);
            this.labelradio.Name = "labelradio";
            this.labelradio.Size = new System.Drawing.Size(31, 15);
            this.labelradio.TabIndex = 10;
            this.labelradio.Text = "Mp3";
            this.labelradio.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Off Radio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 12;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "BMW",
            "Mercedes-Benz",
            "Audi",
            "Jeep",
            "Ford",
            "Toyota",
            "Hyundai",
            "Honda",
            "Porche"});
            this.comboBoxMarca.Location = new System.Drawing.Point(254, 31);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMarca.TabIndex = 13;
            this.comboBoxMarca.Text = "Escoge Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(868, 480);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelradio);
            this.Controls.Add(this.buttonRadio);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.buttonAltoTotal);
            this.Controls.Add(this.labelEstadoVelocidad);
            this.Controls.Add(this.buttonAcelerar);
            this.Controls.Add(this.buttonEncender);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.buttonInicio);
            this.Name = "Form1";
            this.Text = "Apagar auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonAcelerar;
        private System.Windows.Forms.Label labelEstadoVelocidad;
        private System.Windows.Forms.Button buttonAltoTotal;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Label labelradio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMarca;
    }
}

