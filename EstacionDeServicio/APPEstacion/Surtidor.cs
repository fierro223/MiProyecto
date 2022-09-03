using Claseslibres;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APPEstacion
{
    using Claseslibres;
    public partial class Surtidor : Form
    {
        public Establecimiento Establecimiento;
        public int precio;
       
        public Surtidor()
        {
            InitializeComponent();
        }

        public Surtidor(Surtidora surtidora)
        {
            InitializeComponent();
            lblSeleccionado.Text=surtidora.TipoDeTanque.getdisponible();
            precio = (int.Parse(lblPrecio.Text = surtidora.TipoDeTanque.Producto.Precio.ToString()));
        }
        private void btnSurtir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            txtLitros.Text = (int.Parse(txtLitros.Text.ToString()) + 1).ToString();

            txtTotal.Text = (int.Parse(txtLitros.Text.ToString()) * precio).ToString();

        }
    }
}
