namespace DDJJDesktop
{
    partial class FmBienVenidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnConRed = new System.Windows.Forms.Button();
            this.BtnSinRed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Organizacion|DDJJ de Salud";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 90);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(109, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(732, 104);
            this.label2.TabIndex = 3;
            this.label2.Text = "Para acceso a las instalaciones debe completar\r\nla Declaracion Jurada de Salud";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnConRed
            // 
            this.BtnConRed.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BtnConRed.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnConRed.ForeColor = System.Drawing.Color.Crimson;
            this.BtnConRed.Location = new System.Drawing.Point(139, 42);
            this.BtnConRed.Name = "BtnConRed";
            this.BtnConRed.Size = new System.Drawing.Size(291, 59);
            this.BtnConRed.TabIndex = 5;
            this.BtnConRed.Text = "CON USUARIO DE RED";
            this.BtnConRed.UseVisualStyleBackColor = false;
            this.BtnConRed.Click += new System.EventHandler(this.BtnConRed_Click);
            // 
            // BtnSinRed
            // 
            this.BtnSinRed.BackColor = System.Drawing.Color.Gainsboro;
            this.BtnSinRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSinRed.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnSinRed.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.BtnSinRed.Location = new System.Drawing.Point(139, 125);
            this.BtnSinRed.Name = "BtnSinRed";
            this.BtnSinRed.Size = new System.Drawing.Size(291, 62);
            this.BtnSinRed.TabIndex = 6;
            this.BtnSinRed.Text = "SIN USUARIO DE RED";
            this.BtnSinRed.UseVisualStyleBackColor = false;
            this.BtnSinRed.Click += new System.EventHandler(this.BtnSinRed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnConRed);
            this.groupBox1.Controls.Add(this.BtnSinRed);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(173, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 218);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione la Forma de Ingreso:";
            // 
            // FmBienVenidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FmBienVenidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmBienVenidos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Button BtnConRed;
        private Button BtnSinRed;
        private GroupBox groupBox1;
    }
}