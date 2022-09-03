using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Jornada
    {
        public int IdJornada { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime HorarioInicio { get; set; }//revisar
        public DateTime HorarioFin { get; set; }
        public Empleado Responsable { get; set; }
        public Establecimiento IdEstablecimiento { get; set; }
    }
}
