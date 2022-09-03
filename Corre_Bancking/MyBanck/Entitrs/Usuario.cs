using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanck.Entitrs
{   
    internal class Usuario
    {
        private string usuario;
        private string clave;
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; internal set; }
        public string Username { get; internal set; }
        public string Clave { get; internal set; }

        public Usuario(string usuario,string clave)
        {
        }

        public Usuario()
        {
        }
    }
}
