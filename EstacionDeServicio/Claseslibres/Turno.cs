using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Turno
    {
        #region
        public int IdTurno { get; set; }
        public string NombreDelTurno { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        #endregion
    }
}
