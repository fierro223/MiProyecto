using Bank.Entities;
using Bank.Services;

namespace Bank
{
    public partial class FrmLogin : Form
    {

        int Contador;
        SecurityServices securityServices; 
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            securityServices = new SecurityServices();
            Usuario UserLogin = null;
            switch (CmbLoginType.SelectedIndex)
            {
                case 0:
                    UserLogin = securityServices.Login(txtUsuario.Text, txtClave.Text);
                    if (UserLogin !=null)
                    {
                        FrmMenuPrincipal menu = new FrmMenuPrincipal(UserLogin);
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        lblNotificacion.BackColor = Color.Red;
                        lblNotificacion.Text = "Los datos ingresados son incorrectos!";
                        lblNotificacion.Visible = true;
                    }
                    break;
                case 1:
                    //var usuario = securityServices.LoginWithData(txtUsuario.Text, txtClave.Text);

                    //if (usuario != null)
                    //{
                    //    FrmMenuPrincipal menu = new FrmMenuPrincipal(usuario);
                    //    menu.Show();
                    //    this.Hide();
                    //}
                    //else
                    //{
                    //    lblNotificacion.BackColor = Color.Red;
                    //    lblNotificacion.Text = "Los datos ingresados son incorrectos!";
                    //    lblNotificacion.Visible = true;
                    //}
                    break;
            }


                     

            //Usuario pedro = new Usuario("pedro", "1234", 75841);
            //Usuario juan = new Usuario("juan", "prueba", 800);

            //juan.login(txtUsuario, txtClave, lblNotificacion);
            //pedro.login(txtUsuario, txtClave, lblNotificacion);
            //La notificacion de ingreso solamente funciona con la ultima linea...
            //se resolveria con el uso de un array de Usuarios.





           
            //lblNotificacion.BackColor = Color.Green;
            //lblNotificacion.Text = "Ingreso exitoso!";
            //lblNotificacion.Visible = true;
            //txtClave.Text = "";
            //txtUsuario.Text = "";


            


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
