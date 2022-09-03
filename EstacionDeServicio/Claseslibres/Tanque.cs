using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Tanque
    {
        public int IdTanque { get; set; }
        public Producto Producto { get; set; }
        public int Capacidad { get; set; }
        public int Disponible { get; set; }

        public void GetCapacidad()
        {

        }

        public string getdisponible()
        {

            return @$"Producto:{Producto.NombreProducto}{Environment.NewLine}Capacidad{Capacidad}{Environment.NewLine}Disponible{Disponible}" ;
        }
        public void CargarTanque()
        {

        }
        public void ExtraerCombustible()
        {

        }

    }
}
