namespace Bank
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblAccion = new System.Windows.Forms.Label();
            this.btnAccion = new System.Windows.Forms.Button();
            this.lblAlerta = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripUser});
            this.statusStrip1.Location = new System.Drawing.Point(5, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuario";
            // 
            // toolStripUser
            // 
            this.toolStripUser.Name = "toolStripUser";
            this.toolStripUser.Size = new System.Drawing.Size(50, 17);
            this.toolStripUser.Text = "PRUEBA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.mnExit});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositoToolStripMenuItem,
            this.retiroToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // depositoToolStripMenuItem
            // 
            this.depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            this.depositoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.depositoToolStripMenuItem.Text = "Deposito";
            this.depositoToolStripMenuItem.Click += new System.EventHandler(this.depositoToolStripMenuItem_Click);
            // 
            // retiroToolStripMenuItem
            // 
            this.retiroToolStripMenuItem.AutoToolTip = true;
            this.retiroToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.retiroToolStripMenuItem.Name = "retiroToolStripMenuItem";
            this.retiroToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.retiroToolStripMenuItem.Text = "Retiro";
            this.retiroToolStripMenuItem.Click += new System.EventHandler(this.retiroToolStripMenuItem_Click);
            // 
            // mnExit
            // 
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(41, 20);
            this.mnExit.Text = "Salir";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenida.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblBienvenida.Location = new System.Drawing.Point(437, 61);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(263, 37);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido $prueba!";
            this.lblBienvenida.Visible = false;
            this.lblBienvenida.Click += new System.EventHandler(this.lblBienvenida_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSaldo.Location = new System.Drawing.Point(437, 109);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(275, 28);
            this.lblSaldo.TabIndex = 3;
            this.lblSaldo.Text = "Su saldo actual es de: $SALDO";
            this.lblSaldo.Visible = false;
            this.lblSaldo.Click += new System.EventHandler(this.lblSaldo_Click);
            // 
            // lblAccion
            // 
            this.lblAccion.AutoSize = true;
            this.lblAccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAccion.Location = new System.Drawing.Point(437, 194);
            this.lblAccion.Name = "lblAccion";
            this.lblAccion.Size = new System.Drawing.Size(210, 20);
            this.lblAccion.TabIndex = 4;
            this.lblAccion.Text = "¿Qué cantidad desea $accion?";
            this.lblAccion.Visible = false;
            this.lblAccion.Click += new System.EventHandler(this.lblAccion_Click);
            // 
            // btnAccion
            // 
            this.btnAccion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAccion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAccion.Location = new System.Drawing.Point(567, 249);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(75, 30);
            this.btnAccion.TabIndex = 6;
            this.btnAccion.Text = "Confirmar";
            this.btnAccion.UseVisualStyleBackColor = false;
            this.btnAccion.Visible = false;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // lblAlerta
            // 
            this.lblAlerta.AutoSize = true;
            this.lblAlerta.BackColor = System.Drawing.Color.Green;
            this.lblAlerta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAlerta.Location = new System.Drawing.Point(446, 299);
            this.lblAlerta.Name = "lblAlerta";
            this.lblAlerta.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lblAlerta.Size = new System.Drawing.Size(120, 25);
            this.lblAlerta.TabIndex = 7;
            this.lblAlerta.Text = "Operación realiazda!";
            this.lblAlerta.Visible = false;
            this.lblAlerta.Click += new System.EventHandler(this.lblAlerta_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtMonto.Location = new System.Drawing.Point(441, 220);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(200, 23);
            this.txtMonto.TabIndex = 5;
            this.txtMonto.Visible = false;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAlerta);
            this.Controls.Add(this.btnAccion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblAccion);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripUser;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem retiroToolStripMenuItem;
        private ToolStripMenuItem mnExit;
        private Label lblBienvenida;
        private Label lblSaldo;
        private Label lblAccion;
        private Button btnAccion;
        private Label lblAlerta;
        private TextBox txtMonto;
    }
}