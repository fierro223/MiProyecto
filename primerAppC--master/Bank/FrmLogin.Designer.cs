namespace Bank
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.loginContainer = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.CmbLoginType = new System.Windows.Forms.ComboBox();
            this.loginContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginContainer
            // 
            resources.ApplyResources(this.loginContainer, "loginContainer");
            this.loginContainer.Controls.Add(this.CmbLoginType);
            this.loginContainer.Controls.Add(this.btnIngresar);
            this.loginContainer.Controls.Add(this.txtClave);
            this.loginContainer.Controls.Add(this.txtUsuario);
            this.loginContainer.Controls.Add(this.lblClave);
            this.loginContainer.Controls.Add(this.lblUsuario);
            this.loginContainer.Name = "loginContainer";
            this.loginContainer.TabStop = false;
            // 
            // btnIngresar
            // 
            resources.ApplyResources(this.btnIngresar, "btnIngresar");
            this.btnIngresar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtClave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtClave.Name = "txtClave";
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUsuario.Name = "txtUsuario";
            // 
            // lblClave
            // 
            resources.ApplyResources(this.lblClave, "lblClave");
            this.lblClave.Name = "lblClave";
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblNotificacion
            // 
            resources.ApplyResources(this.lblNotificacion, "lblNotificacion");
            this.lblNotificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotificacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNotificacion.Name = "lblNotificacion";
            // 
            // CmbLoginType
            // 
            resources.ApplyResources(this.CmbLoginType, "CmbLoginType");
            this.CmbLoginType.FormattingEnabled = true;
            this.CmbLoginType.Items.AddRange(new object[] {
            resources.GetString("CmbLoginType.Items"),
            resources.GetString("CmbLoginType.Items1")});
            this.CmbLoginType.Name = "CmbLoginType";
            // 
            // FrmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNotificacion);
            this.Controls.Add(this.loginContainer);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.loginContainer.ResumeLayout(false);
            this.loginContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox loginContainer;
        private Button btnIngresar;
        private TextBox txtClave;
        private TextBox txtUsuario;
        private Label lblClave;
        private Label lblUsuario;
        private Label lblNotificacion;
        private ComboBox CmbLoginType;
    }
}