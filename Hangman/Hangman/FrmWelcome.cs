namespace Hangman
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

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (TxtUser.Text.Trim().Length > 0)
            {
                FrmHangman frmHangaman = new FrmHangman(TxtUser.Text);
                frmHangaman.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Error: El nombre de usuario es necesario.");
            }
        }
    }
}
