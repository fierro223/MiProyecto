namespace Hangman
{
    partial class FrmHangman
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblWelcome = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.LblWord = new System.Windows.Forms.Label();
            this.BtnChange = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtSend = new System.Windows.Forms.TextBox();
            this.LblTries = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblWelcome
            // 
            this.LblWelcome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblWelcome.Location = new System.Drawing.Point(12, 19);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(275, 34);
            this.LblWelcome.TabIndex = 0;
            this.LblWelcome.Text = "Bienvenido ";
            this.LblWelcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblScore.Location = new System.Drawing.Point(606, 24);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(100, 25);
            this.LblScore.TabIndex = 2;
            this.LblScore.Text = "Puntuación";
            // 
            // LblWord
            // 
            this.LblWord.AutoSize = true;
            this.LblWord.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblWord.Location = new System.Drawing.Point(12, 116);
            this.LblWord.Name = "LblWord";
            this.LblWord.Size = new System.Drawing.Size(166, 54);
            this.LblWord.TabIndex = 3;
            this.LblWord.Text = "palabra";
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(71, 422);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(113, 23);
            this.BtnChange.TabIndex = 4;
            this.BtnChange.Text = "Cambiar palabra";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(687, 135);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 5;
            this.BtnSend.Text = "Enviar";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // TxtSend
            // 
            this.TxtSend.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtSend.Location = new System.Drawing.Point(581, 135);
            this.TxtSend.MaxLength = 1;
            this.TxtSend.Name = "TxtSend";
            this.TxtSend.Size = new System.Drawing.Size(100, 23);
            this.TxtSend.TabIndex = 6;
            this.TxtSend.TextChanged += new System.EventHandler(this.TxtSend_TextChanged);
            // 
            // LblTries
            // 
            this.LblTries.AutoSize = true;
            this.LblTries.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblTries.Location = new System.Drawing.Point(283, 19);
            this.LblTries.Name = "LblTries";
            this.LblTries.Size = new System.Drawing.Size(103, 28);
            this.LblTries.TabIndex = 7;
            this.LblTries.Text = "Intentos: 0";
            // 
            // FrmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTries);
            this.Controls.Add(this.TxtSend);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.LblWord);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.LblWelcome);
            this.Name = "FrmHangman";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmHangman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblWelcome;
        private Label LblScore;
        private Label LblWord;
        private Button BtnChange;
        private Button BtnSend;
        private TextBox TxtSend;
        private Label LblTries;
    }
}