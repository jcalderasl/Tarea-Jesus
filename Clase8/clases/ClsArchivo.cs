using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Clase8.clases
{
    class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] Lineas = File.ReadAllLines(archivo);
            return Lineas;
        }

        public string LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using (StreamReader reader = new StreamReader(archivo))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }

    }
}
