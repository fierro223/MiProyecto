using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDJJDesktop
{
    public partial class FmFormulario2 : Form
    {
        public FmFormulario2()
        {
            InitializeComponent();
        }

        private void btnAtras1_Click(object sender, EventArgs e)
        {
            FmFormulario1 fmFormulario1 = new FmFormulario1();
            fmFormulario1.Show();
            this.Close();
        }

        private void BtnSiguiente2_Click(object sender, EventArgs e)
        {
            FmFormulario3 fmFormulario3= new FmFormulario3();
            fmFormulario3.Show();
            this.Close();
        }
    }
}
