using Jesus.Clases.archivos;
using Jesus.Clases.BaseDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Jesus
{
    public partial class frmInicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void cargarArchivoExterno()
        {
            string fuente = @"C:\Users\alumno\Videos\ArchivoPlano.csv";
            ClsArchivo ar = new ClsArchivo();
            ClsConexion cn = new ClsConexion();


            string[] ArregloNotas = ar.LeerArchivo(fuente);
            string sentencia_sql = "";
            int NumeroLinea = 0;

            foreach (string Linea in ArregloNotas)
            {
                string[] datos = Linea.Split(';');
                if (NumeroLinea > 0)
                {
                    sentencia_sql += $"insert into tb_alumnos values({datos[0]},'{datos[1]}',{datos[2]},{datos[3]},{datos[4]},{datos[5]},'{datos[6]}');\n";
                }
                NumeroLinea++;
            }
            NumeroLinea = 0;
            cn.EjecutaSQLDirecto(sentencia_sql);
        }


        protected void ButtonCargaDatos_Click(object sender, EventArgs e)
        {
            cargarArchivoExterno();
        }

        protected void ButtonBuscarID_Click(object sender, EventArgs e)
        {
            string id = TextBoxID.Text.Trim();
            ClsConexion cn = new ClsConexion();
            DataTable dt = new DataTable(); //representa una tabla con sus filas y columnas
            string sentencia = $"select * from tb_alumnos where correlativo = {id}";
            dt = cn.consultaTablaDirecta(sentencia);
            if (dt.Rows.Count > 0)
            {
                string nombre = dt.Rows[0].Field<string>("nombre");
                TextBoxNombre.Text = nombre;
            }
            else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }
        }

        protected void ButtonBuscarNombre_Click(object sender, EventArgs e)
        {
            string nombre = TextBoxNombre.Text.Trim();
            ClsConexion cn = new ClsConexion();
            DataTable dt = new DataTable(); //representa una tabla con sus filas y columnas
            string sentencia = $"select * from tb_alumnos where nombre like ('%{nombre}%')";
            dt = cn.consultaTablaDirecta(sentencia);
            if (dt.Rows.Count > 0)
            {
                int id = dt.Rows[0].Field<Int32>("correlativo");
                TextBoxID.Text = id+"";
            }
            else
            {
                TextBoxNombre.Text = "NO HAY INFORMACION";
            }
        }

    }
    
}