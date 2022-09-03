using Bank.Entities;

namespace Bank.DataStorage
{
    public class SecurityData
    {
        //Declaramos e instanciamos el Array
        private Usuario[] arrayUsers = new Usuario[4];

        public SecurityData()
        {
            //Llenamos cada posición de memoria con una instancia de Usuario
            arrayUsers[0] = new Usuario("vcordero","123456","Victor","Cordero");
            arrayUsers[1] = new Usuario("franco", "0124", "Franco", "Aguayo");
            arrayUsers[2] = new Usuario("zambrano", "321", "Daniela", "Zambrano");
            arrayUsers[3] = new Usuario("alison", "879", "Alison", "Morel");
        }

        public Usuario[] getListUsers()
        {
            return arrayUsers;
        }

    }
}
