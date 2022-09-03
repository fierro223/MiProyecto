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
    public partial class FmFormulario1 : Form
    {
        public FmFormulario1()
        {
            InitializeComponent();
        }

        private void BtnSiguiente1_Click(object sender, EventArgs e)
        {
            FmFormulario2 fmFormulario2 = new FmFormulario2();
            fmFormulario2.Show();
            this.Close();
        }
    }
}
