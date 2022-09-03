using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDJJAdministrator.Entidades
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Password { get; set; }

       public DatosPersonales DatosPersonalesUsuario { get; set; }
    }
}
