namespace Bank
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            lblImpresion.Text = $"Bienvenidx {texto} !!";
            lblImpresion.Visible = true;
        }

    }
}