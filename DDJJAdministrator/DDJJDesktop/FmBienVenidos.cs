namespace DDJJDesktop
{
    public partial class FmBienVenidos : Form
    {
        public FmBienVenidos()
        {
            InitializeComponent();
        }
        private void BtnConRed_Click(object sender, EventArgs e)
        {
            FmCredenciales fmCredenciale = new FmCredenciales();
            fmCredenciale.Show();
            this.Hide();
        }
        private void BtnSinRed_Click(object sender, EventArgs e)
        {
            FmFormulario1 fmFormulario1 = new FmFormulario1();
            fmFormulario1.Show();
            this.Hide();
        }

       
    }
}
