using Bank.Entities;

namespace Bank
{
    public partial class FrmMenuPrincipal : Form
    {
        Usuario user;
        public FrmMenuPrincipal()
        {
            InitializeComponent();// constructor al inicio siempre
        }

        public FrmMenuPrincipal(Usuario user)
        {
            InitializeComponent();// constructor al inicio siempre
            this.user = user;
            string usuario = user.Username;
            float saldo = user.Saldo;
            toolStripUser.Text = user.Username;
            lblBienvenida.Text = $"Bienvenido {user.FirstName} {user.LastName} !";
            lblBienvenida.Visible = true;
            lblSaldo.Text = $"Su saldo actual es de: ${saldo}";
            lblSaldo.Visible = true;
        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            string message = "Está seguro de que quiere cerrar el programa?";
            string title = "Cancelar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // sigue la ejecución
            }
        }
             

        private void depositoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAccion.Text = "¿Qué cantidad desea depositar?";
            lblAccion.Visible = true;
            txtMonto.Visible = true;
            btnAccion.Visible = true;
        }

        private void retiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblAccion.Text = "¿Qué cantidad desea retirar?";
            lblAccion.Visible = true;
            txtMonto.Visible = true;
            btnAccion.Visible = true;
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {

            try
            {
                int monto = int.Parse(txtMonto.Text);
                if (lblAccion.Text.Contains("depositar"))
                {

                    if (monto > 0)
                    {
                        user.Saldo += monto;
                        lblSaldo.Text = $"Su saldo actual es de: ${user.Saldo}";
                        lblAlerta.Text = "Deposito realizado exitosamente!";
                        lblAlerta.BackColor = Color.DarkGreen;
                        lblAlerta.Visible = true;
                        txtMonto.Text = "";
                    }
                    else
                    {
                        lblAlerta.Text = "Por favor ingrese un numero válido!";
                        lblAlerta.BackColor = Color.Red;
                        lblAlerta.Visible = true;
                        txtMonto.Text = "";
                    }
                }
                else
                {

                    if (monto <= user.Saldo && monto > 0)
                    {
                        user.Saldo -= monto;
                        lblSaldo.Text = $"Su saldo actual es de: ${user.Saldo}";
                        lblAlerta.Text = $"Retiró ${monto} exitosamente!";
                        lblAlerta.BackColor = Color.DarkGreen;
                        lblAlerta.Visible = true;
                        txtMonto.Text = "";
                    }
                    else
                    {
                        if (monto > 0)
                        {
                            lblAlerta.Text = $"Saldo insuficiente, no puede retirar ${monto}!";
                            lblAlerta.BackColor = Color.Red;
                            lblAlerta.Visible = true;
                            txtMonto.Text = "";
                        }
                        else
                        {
                            lblAlerta.Text = $"Monto inválido, no puede retirar ${monto}!";
                            lblAlerta.BackColor = Color.Red;
                            lblAlerta.Visible = true;
                            txtMonto.Text = "";
                        }
                    }
                }
            }
            catch (Exception error)
            {
                lblAlerta.Text = "Error, Debe ingresar un número!";
                lblAlerta.BackColor = Color.Red;
                lblAlerta.Visible = true;
                Console.WriteLine(error);
            }



        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAccion_Click(object sender, EventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void lblAlerta_Click(object sender, EventArgs e)
        {

        }
    }
}
