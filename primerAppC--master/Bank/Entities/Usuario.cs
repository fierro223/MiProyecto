namespace Bank.Entities
{
    public class Usuario
    {
        //private int id;
        //private string name;
        //private DateTime fechaNac;
        private string usuario;
        private string clave;
        private float saldo;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Usuario() { }

        public Usuario(string usuario, string clave, float saldo)
        {
            Username = usuario;
            Clave = clave;
            Saldo = saldo;
        }

        public Usuario(string usuario, string clave, string firstName, string lastName)
        {
            Username = usuario;
            Clave = clave;
            Saldo = 0;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Username
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public float Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        
    }
}
