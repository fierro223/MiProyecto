using MyBanck.Entitrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanck.DataStorage
{
    public class SecurityData
    {
        //declaramos e istanciamos el array
        private Usuario[] arrayUsers = new Usuario[4];

        public SecurityData()
        {
            //Llenamos cada posicion de memoria con una instancia Usuario
            arrayUsers[0] = new Usuario("EFierro","123456");
            arrayUsers[1] = new Usuario("FAguayo", "12345");
            arrayUsers[2] = new Usuario("CGoody", "1234");
            arrayUsers[3] = new Usuario("VCordero", "123");


        }
        public Usuario[] GetListUsers()
        {
            return arrayUsers;
        }
    }
}
