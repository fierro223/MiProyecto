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
    
    //public class FrmMenuPrincipal
    //{
    //    InitializeComponent();

    //}
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(string userLogin)
        {
            InitializeComponent();//Primero
            toolStripUser.Text= userLogin;
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        private void Exit()
        {
            if (MessageBox.Show(this, "¿Seguro que desea Salir?",
            "Salir del Sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
