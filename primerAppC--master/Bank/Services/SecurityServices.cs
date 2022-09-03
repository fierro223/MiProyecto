using Bank.DataStorage;
using Bank.Entities;

namespace Bank.Services
{
    public class SecurityServices
    {
        SecurityData securityData = new SecurityData();
        public Usuario Login(string UserLogin, string ClaveLogin)
        {
            Usuario Result = null;

            var arrayUsers = securityData.getListUsers();

            //for (int Indice = 0; Indice < arrayUsers.Length; Indice++)
            //{
            //    if (UserLogin == arrayUsers[Indice].Username && ClaveLogin == arrayUsers[Indice].Clave)
            //    {
            //        Result = arrayUsers[Indice];
            //        break;
            //    }
            //}

            foreach (Usuario User in arrayUsers)
            {
                if (UserLogin == User.Username && ClaveLogin == User.Clave)
                {
                    Result = User;
                    break;
                }
            }

            return Result;

        }
    }
}
