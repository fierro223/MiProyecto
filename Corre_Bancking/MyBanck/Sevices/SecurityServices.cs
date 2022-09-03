using MyBanck.DataStorage;
using MyBanck.Entitrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanck.Sevices
{
    
       

    public class SecurityServices
    {
        private SecurityData securityData = new SecurityData();
       
        public bool Login(string UserLogin, string ClaveLogin)
        {
            bool Result = false;
            var arrayUsers = securityData.GetListUsers();
            for(int Indice = 0; Indice < arrayUsers.Length; Indice++)
            {
                if(UserLogin== arrayUsers[Indice].Username && ClaveLogin== arrayUsers[Indice].Clave)
                {
                    Result=true;
                    break;
                }
            }
           // foreach (Usuario User in UserList)
            //{
              //if (UserLogin == User.Username && ClaveLogin== User.Clave)
                //{
                  //  Result = true;
                    //break;
                //}
           // }
                

            if(UserLogin == "DEMO" &&  ClaveLogin == "1234")
            {
                Result = true;

            }
            return Result;
        }
        
        public Usuario LoginWithDato(String UserLogin, String ClaveLogin)
        {   
            Usuario Result=null;
            if(UserLogin == "DEMO" && ClaveLogin == "12345")
            {
                Result = new Usuario() { FirstName = "Emiliano", LastName = "Fierro" };
            }
            return Result;

        }
    }
}
