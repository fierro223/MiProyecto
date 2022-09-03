using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Surtidora
    {
        public int IdSurtidor { get; set; }
        public int Secuencia { get; set; }
        public int LitrosSurtido { get; set; }
        public double MontoSurtido { get; set; }
        public Persona Playero { get; set; }
        public Tanque TipoDeTanque { get; set; }
        public double precio { get; set; }
       
        public void SurtirCombustible()
        {

        }
    }
}
