using MyBanck.Sevices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBanck
{
    public partial class FrmLogin : Form
    {
        SecurityServices securityServices;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            securityServices=new SecurityServices();
            if (securityServices.Login(TxtUser.Text, TxtPassword.Text)){ 
                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(TxtUser.Text);
                frmMenu.Show();
                this.Hide();
            }
            else
            {
                

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
