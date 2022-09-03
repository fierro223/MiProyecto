using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DDJJAdministrator.Entidades;

namespace DDJJAdministrator.DataStore
{
    public class UsuariosRepositorio
    {
        //retorna Lista de Usuario
        public List<Usuario> GetAllUsers()
        {
            List<Usuario> LstSintomas = new List<Usuario>() {
            new Usuario()
            {
                Login="Efierro",
                Password="12345",
                DatosPersonalesUsuario=new DatosPersonales()
                {
                    NDniOPasaporte="12345678",
                    Nombre="Emiliano",
                    Apellido="Fierro",
                }
            },
            new Usuario()
            {
                Login = "Cgodoy",
                Password = "12345",
                DatosPersonalesUsuario = new DatosPersonales()
                {
                    NDniOPasaporte = "12345678",
                    Nombre = "Cristian",
                    Apellido = "Godoy",
                }
            }};
            


            return LstSintomas;
        }
    }
}
