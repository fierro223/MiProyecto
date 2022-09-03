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
    public partial class MenuGNS : Form
    {
        private Establecimiento estacion;

        public MenuGNS()
        {
            InitializeComponent();
        }

        public MenuGNS(Establecimiento estacion)
        {
            InitializeComponent();
            this.estacion = estacion;
            lblDatos.Text = estacion.getDatosEstacion();
            lblTanque1.Text = estacion.Tanques[0].getdisponible();
            lblTanque2.Text= estacion.Tanques[1].getdisponible();
            lblTanque3.Text= estacion.Tanques[2].getdisponible();
            
        }
        //private void btnPremium_Click(object sender, EventArgs e)
        //{
        //    Surtidor pantalla1 = new Surtidor(estacion.Surtidora[0]);
        //    pantalla1.Show();

        //}

        private void btnDiesel_Click(object sender, EventArgs e)
        {
            Surtidor pantalla1 = new Surtidor(estacion.Surtidora[1]);
            pantalla1.Show();
        }

        private void btnSuper_Click(object sender, EventArgs e)
        {
            Surtidor pantalla1 = new Surtidor(estacion.Surtidora[2]);
            pantalla1.Show();
        }

        private void btnPremium_Click_1(object sender, EventArgs e)
        {
            Surtidor pantalla1 = new Surtidor(estacion.Surtidora[0]);
            pantalla1.Show();


        }
    }
}
