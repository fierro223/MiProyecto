using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Persona
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direcion { get; set; }

        public Persona()
        {

        }
        public Persona(string dni, string nombre, string apellido, string telefono, string direcion)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            Direcion = direcion;
        }
    }
}