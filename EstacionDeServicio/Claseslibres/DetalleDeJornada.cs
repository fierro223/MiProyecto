using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class DetalleDeJornada
    {
        public Jornada IdJornada { get; set; }
        public Turno Turno { get; set; }
        public Empleado Empleado { get; set; }
        public Surtidora Surtidora { get; set; }
        public Surtidora Litrossurtido { get; set; }
        public DateTime Horastrabajadas { get; set; }
        public double TotalRecaudado { get; set; }
    }
}
