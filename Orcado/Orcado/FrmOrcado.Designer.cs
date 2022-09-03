namespace Orcado
{
    partial class FrmOrcado
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
            this.LblWord = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.LblTries = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.ltrUsed = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblWord
            // 
            this.LblWord.AutoSize = true;
            this.LblWord.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWord.ForeColor = System.Drawing.Color.Goldenrod;
            this.LblWord.Location = new System.Drawing.Point(48, 155);
            this.LblWord.Name = "LblWord";
            this.LblWord.Size = new System.Drawing.Size(206, 67);
            this.LblWord.TabIndex = 1;
            this.LblWord.Text = "palabra";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 19);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(118, 28);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido";
            // 
            // BtnChange
            // 
            this.BtnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnChange.Location = new System.Drawing.Point(332, 268);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(196, 42);
            this.BtnChange.TabIndex = 2;
            this.BtnChange.Text = "Nueva Palabra";
            this.BtnChange.UseVisualStyleBackColor = false;
            this.BtnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(544, 172);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(40, 27);
            this.txtSend.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Lime;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(659, 155);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(83, 54);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // LblTries
            // 
            this.LblTries.AutoSize = true;
            this.LblTries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblTries.Location = new System.Drawing.Point(313, 19);
            this.LblTries.Name = "LblTries";
            this.LblTries.Size = new System.Drawing.Size(113, 28);
            this.LblTries.TabIndex = 5;
            this.LblTries.Text = "Intentos: 0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(620, 19);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(113, 28);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Puntiacion";
            // 
            // ltrUsed
            // 
            this.ltrUsed.FormattingEnabled = true;
            this.ltrUsed.ItemHeight = 20;
            this.ltrUsed.Location = new System.Drawing.Point(12, 334);
            this.ltrUsed.Name = "ltrUsed";
            this.ltrUsed.Size = new System.Drawing.Size(150, 104);
            this.ltrUsed.TabIndex = 7;
            // 
            // FrmOrcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ltrUsed);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.LblTries);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LblWord);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FrmOrcado";
            this.Text = "FrmOrcado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWelcome;
        private Label LblWord;
        private Button BtnChange;
        private TextBox txtSend;
        private Button btnSend;
        private Label LblTries;
        private Label lblScore;
        private ListBox ltrUsed;
    }
}