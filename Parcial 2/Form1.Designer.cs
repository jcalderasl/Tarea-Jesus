
namespace Clase8
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
            this.buttonArreglo = new System.Windows.Forms.Button();
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.buttonNombres = new System.Windows.Forms.Button();
            this.buttonParcial = new System.Windows.Forms.Button();
            this.buttonPromedio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonArreglo
            // 
            this.buttonArreglo.Location = new System.Drawing.Point(679, 440);
            this.buttonArreglo.Name = "buttonArreglo";
            this.buttonArreglo.Size = new System.Drawing.Size(122, 31);
            this.buttonArreglo.TabIndex = 0;
            this.buttonArreglo.Text = "Arreglo";
            this.buttonArreglo.UseVisualStyleBackColor = true;
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 15;
            this.listBoxResultado.Location = new System.Drawing.Point(135, 201);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(666, 184);
            this.listBoxResultado.TabIndex = 1;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(135, 21);
            this.textBoxResultado.Multiline = true;
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultado.Size = new System.Drawing.Size(666, 174);
            this.textBoxResultado.TabIndex = 2;
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.Location = new System.Drawing.Point(3, 93);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(100, 39);
            this.buttonCargarArchivo.TabIndex = 3;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = true;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // buttonNombres
            // 
            this.buttonNombres.Location = new System.Drawing.Point(3, 138);
            this.buttonNombres.Name = "buttonNombres";
            this.buttonNombres.Size = new System.Drawing.Size(100, 25);
            this.buttonNombres.TabIndex = 4;
            this.buttonNombres.Text = "Nombres";
            this.buttonNombres.UseVisualStyleBackColor = true;
            this.buttonNombres.Click += new System.EventHandler(this.buttonNombres_Click);
            // 
            // buttonParcial
            // 
            this.buttonParcial.Location = new System.Drawing.Point(12, 407);
            this.buttonParcial.Name = "buttonParcial";
            this.buttonParcial.Size = new System.Drawing.Size(100, 44);
            this.buttonParcial.TabIndex = 5;
            this.buttonParcial.Text = "Resul de Nota Mayor y Menor";
            this.buttonParcial.UseVisualStyleBackColor = true;
            this.buttonParcial.Click += new System.EventHandler(this.buttonParcial_Click_1);
            // 
            // buttonPromedio
            // 
            this.buttonPromedio.Location = new System.Drawing.Point(3, 172);
            this.buttonPromedio.Name = "buttonPromedio";
            this.buttonPromedio.Size = new System.Drawing.Size(100, 23);
            this.buttonPromedio.TabIndex = 6;
            this.buttonPromedio.Text = "Promedio";
            this.buttonPromedio.UseVisualStyleBackColor = true;
            this.buttonPromedio.Click += new System.EventHandler(this.buttonPromedio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 495);
            this.Controls.Add(this.buttonPromedio);
            this.Controls.Add(this.buttonParcial);
            this.Controls.Add(this.buttonNombres);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.listBoxResultado);
            this.Controls.Add(this.buttonArreglo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonArreglo;
        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Button buttonCargarArchivo;
        private System.Windows.Forms.Button buttonNombres;
        private System.Windows.Forms.Button buttonParcial;
        private System.Windows.Forms.Button buttonPromedio;
    }
}

