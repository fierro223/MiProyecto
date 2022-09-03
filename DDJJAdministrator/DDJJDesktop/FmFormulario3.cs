using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DDJJAdministrador.Services;

namespace DDJJDesktop
{
    public partial class FmFormulario3 : Form
    {
        MaestrosServices datosMaestrosService=new MaestrosServices();
        DeclaracionJuradaService juradaService = new DeclaracionJuradaService();
        public FmFormulario3()
        {
            InitializeComponent();
            //var listaSintoma = maestroService.ListarSintomas();
            this.lisSintoma.DataSource = datosMaestrosService.ListarSintomas(); 
            this.lisSintoma.DisplayMember = "NombreSintoma";
            this.lisSintoma.ValueMember = "IdSintoma";
            
        }

        private void BtnAtras2_Click(object sender, EventArgs e)
        {
            FmFormulario2 fmFormulario2 = new FmFormulario2();
            fmFormulario2.Show();
            this.Close();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            FmFinal fmFinal= new FmFinal();
            fmFinal.Show();
            this.Close();
        }
               
    }
}
