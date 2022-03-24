namespace MyBanck
{
    public partial class FrmMail : Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool SaveResult = false;
            if (SaveResult)
            {
                lrmMensage.Text = "Cliente registrdado correctamente";
                lrmMensage.ForeColor = Color.Green;
                lrmMensage.Visible = true;
            }
            else
            {
                lrmMensage.Text = "Cliente registrdado correctamente";
                lrmMensage.ForeColor = Color.Red;
                lrmMensage.Visible = true;
            }
        }




    }
}
