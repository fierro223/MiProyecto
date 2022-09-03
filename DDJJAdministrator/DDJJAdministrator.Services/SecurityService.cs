using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.Entidades;
using DDJJAdministrator.DataStore;

namespace DDJJAdministrator.Services
{
    public class SecurityService
    {
        UsuariosRepositorio usuarioRepositorio = new UsuariosRepositorio();
        
        public Usuario Autenticar(string Login, string Password)
        {
            Usuario userRetun = null;
            var lstUsuario = usuarioRepositorio.GetAllUsers();
            foreach (var usuario in lstUsuario)
            {
                if(usuario.Login == Login && usuario.Password== Password)
                {
                    userRetun = usuario;
                }
            }

            return userRetun;
        }
    }
}
