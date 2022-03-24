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
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenu = new FrmMenuPrincipal(TxtUser.Text);
            frmMenu.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
