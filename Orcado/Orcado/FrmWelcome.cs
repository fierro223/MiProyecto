namespace Orcado
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void botAceder_Click(object sender, EventArgs e)
        {
            if (texNombre.Text.Trim().Length > 0)
            {
                FrmOrcado frmOrcado = new FrmOrcado(texNombre.Text);
                frmOrcado.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error: El nombre de usuario es necesario.");
            }

        }
    }
}
