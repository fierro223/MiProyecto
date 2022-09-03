namespace DDJJDesktop
{
    public partial class FmCredenciales : Form
    {
        public FmCredenciales()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text != "") && (TxtContasenia.Text != ""))
            {
                if ((TxtUsuario.Text == "Admin") && (TxtContasenia.Text == "1234"))
                {
                    FmFormulario2 fmFormulario2 = new FmFormulario2();
                    fmFormulario2.Show();
                    this.Close();
                }
            }
        }

    }
}
