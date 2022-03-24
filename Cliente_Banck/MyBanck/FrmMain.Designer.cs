namespace MyBanck
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botSave = new System.Windows.Forms.Button();
            this.lbmMensage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Location = new System.Drawing.Point(47, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // botSave
            // 
            this.botSave.BackColor = System.Drawing.Color.IndianRed;
            this.botSave.Location = new System.Drawing.Point(577, 290);
            this.botSave.Name = "botSave";
            this.botSave.Size = new System.Drawing.Size(94, 29);
            this.botSave.TabIndex = 1;
            this.botSave.Text = "Guardar";
            this.botSave.UseVisualStyleBackColor = false;
            this.botSave.Click += new System.EventHandler(this.botSave_Click);
            // 
            // lbmMensage
            // 
            this.lbmMensage.AutoSize = true;
            this.lbmMensage.CausesValidation = false;
            this.lbmMensage.Location = new System.Drawing.Point(301, 295);
            this.lbmMensage.Name = "lbmMensage";
            this.lbmMensage.Size = new System.Drawing.Size(69, 20);
            this.lbmMensage.TabIndex = 2;
            this.lbmMensage.Text = "Mensage";
            
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbmMensage);
            this.Controls.Add(this.botSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button botSave;
        private Label lbmMensage;
    }
}