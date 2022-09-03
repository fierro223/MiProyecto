using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Empleado:Persona
    {
        public int IdEmpleado { get; set; }
        public string Codigo { get; set; }
        public string Cargo { get; set; }

        public Empleado()
        {

        }
        public Empleado(int idEmpleado, string codigo,string Cargo, string dni,
            string nombre, string apellido, string telefono, string direcion) :
            base(dni,nombre,apellido,telefono,direcion)
        {
            IdEmpleado = idEmpleado;
            Codigo = codigo;
        }
        
    }
}
