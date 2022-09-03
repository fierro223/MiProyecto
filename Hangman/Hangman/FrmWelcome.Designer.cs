namespace Hangman
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
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(364, 141);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 23);
            this.TxtUser.TabIndex = 0;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(364, 123);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(47, 15);
            this.LblUser.TabIndex = 1;
            this.LblUser.Text = "Usuario";
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(364, 188);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(100, 23);
            this.BtnPlay.TabIndex = 3;
            this.BtnPlay.Text = "Jugar";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TxtUser);
            this.Name = "FrmWelcome";
            this.Text = "FrmWelcome";
            this.Load += new System.EventHandler(this.FrmWelcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TxtUser;
        private Label LblUser;
        private Button BtnPlay;
    }
}