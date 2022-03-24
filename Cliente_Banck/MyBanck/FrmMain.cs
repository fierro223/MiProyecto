namespace MyBanck
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void botSave_Click(object sender, EventArgs e)
        {
            bool saveResult = false;
            if (saveResult)
            {
                lbmMensage.Text = "Cliente reguistrado corresctamente";
                lbmMensage.ForeColor = Color.Green;
                lbmMensage.Visible = true;
            }
            else
            {
                lbmMensage.Text = "Cliente reguistrado corresctamente";
                lbmMensage.ForeColor = Color.Red;
                lbmMensage.Visible = true;
            }
        }


    }
}