namespace Orcado
{
    partial class FrmWelcome
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
            this.botAceder = new System.Windows.Forms.Button();
            this.labUsuario = new System.Windows.Forms.Label();
            this.texNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botAceder
            // 
            this.botAceder.Location = new System.Drawing.Point(362, 216);
            this.botAceder.Name = "botAceder";
            this.botAceder.Size = new System.Drawing.Size(94, 29);
            this.botAceder.TabIndex = 0;
            this.botAceder.Text = "Aceder";
            this.botAceder.UseVisualStyleBackColor = true;
            this.botAceder.Click += new System.EventHandler(this.botAceder_Click);
            // 
            // labUsuario
            // 
            this.labUsuario.AutoSize = true;
            this.labUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labUsuario.Location = new System.Drawing.Point(362, 56);
            this.labUsuario.Name = "labUsuario";
            this.labUsuario.Size = new System.Drawing.Size(79, 28);
            this.labUsuario.TabIndex = 1;
            this.labUsuario.Text = "Usuario";
            // 
            // texNombre
            // 
            this.texNombre.Location = new System.Drawing.Point(346, 141);
            this.texNombre.Name = "texNombre";
            this.texNombre.Size = new System.Drawing.Size(125, 27);
            this.texNombre.TabIndex = 2;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.texNombre);
            this.Controls.Add(this.labUsuario);
            this.Controls.Add(this.botAceder);
            this.Name = "FrmWelcome";
            this.Text = "FrmWelcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botAceder;
        private Label labUsuario;
        private TextBox texNombre;
    }
}