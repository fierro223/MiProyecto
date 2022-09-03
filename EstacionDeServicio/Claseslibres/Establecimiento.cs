using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Claseslibres
{
    public class Establecimiento
    {
        #region propiedades de Clases
        public int IdEstablecimiento { get; set; }
        public string Cuit { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direcion { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public List<Surtidora> Surtidora { get; set; }
        public List<Tanque> Tanques { get; set; }
        public List <Turno> Turnos { get; set; }
        #endregion

        #region metodos
        public string getDatosEstacion()
        {
            string datosEstacion = @$"Cuit:{Cuit} {Environment.NewLine}IdEstacion:{IdEstablecimiento}{Environment.NewLine}Nombre:{Nombre}{Environment.NewLine}Telefono:{Telefono}{Environment.NewLine}Direcion:{Direcion}{Environment.NewLine}Horario de Entrada:{Desde}{Environment.NewLine}Horario de Salida:{Hasta}"; 

            return datosEstacion;
        }
        #endregion
    }
}
