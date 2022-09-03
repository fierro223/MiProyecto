namespace APPEstacion
{
    partial class MenuGNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuGNS));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grBoxTipoCombustible = new System.Windows.Forms.GroupBox();
            this.btnSuper = new System.Windows.Forms.Button();
            this.btnDiesel = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            this.lblTanque3 = new System.Windows.Forms.Label();
            this.lblTanque2 = new System.Windows.Forms.Label();
            this.lblTanque1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grBoxTipoCombustible.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(329, 240);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(122, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // grBoxTipoCombustible
            // 
            this.grBoxTipoCombustible.Controls.Add(this.btnSuper);
            this.grBoxTipoCombustible.Controls.Add(this.btnDiesel);
            this.grBoxTipoCombustible.Controls.Add(this.btnPremium);
            this.grBoxTipoCombustible.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grBoxTipoCombustible.Location = new System.Drawing.Point(146, 501);
            this.grBoxTipoCombustible.Name = "grBoxTipoCombustible";
            this.grBoxTipoCombustible.Size = new System.Drawing.Size(510, 112);
            this.grBoxTipoCombustible.TabIndex = 19;
            this.grBoxTipoCombustible.TabStop = false;
            this.grBoxTipoCombustible.Text = "¿Cual quieres surtir?";
            // 
            // btnSuper
            // 
            this.btnSuper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSuper.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnSuper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSuper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSuper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuper.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSuper.Location = new System.Drawing.Point(355, 38);
            this.btnSuper.Name = "btnSuper";
            this.btnSuper.Size = new System.Drawing.Size(150, 41);
            this.btnSuper.TabIndex = 0;
            this.btnSuper.Text = "SUPER";
            this.btnSuper.UseVisualStyleBackColor = false;
            // 
            // btnDiesel
            // 
            this.btnDiesel.BackColor = System.Drawing.Color.Goldenrod;
            this.btnDiesel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiesel.Location = new System.Drawing.Point(184, 38);
            this.btnDiesel.Name = "btnDiesel";
            this.btnDiesel.Size = new System.Drawing.Size(142, 41);
            this.btnDiesel.TabIndex = 1;
            this.btnDiesel.Text = "DIESEL";
            this.btnDiesel.UseVisualStyleBackColor = false;
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.Olive;
            this.btnPremium.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPremium.Location = new System.Drawing.Point(5, 38);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(148, 41);
            this.btnPremium.TabIndex = 2;
            this.btnPremium.Text = "PREMIUM";
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click_1);
            // 
            // lblTanque3
            // 
            this.lblTanque3.AutoSize = true;
            this.lblTanque3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTanque3.Location = new System.Drawing.Point(617, 375);
            this.lblTanque3.Name = "lblTanque3";
            this.lblTanque3.Size = new System.Drawing.Size(72, 21);
            this.lblTanque3.TabIndex = 18;
            this.lblTanque3.Text = "Tanque 3";
            // 
            // lblTanque2
            // 
            this.lblTanque2.AutoSize = true;
            this.lblTanque2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTanque2.Location = new System.Drawing.Point(337, 375);
            this.lblTanque2.Name = "lblTanque2";
            this.lblTanque2.Size = new System.Drawing.Size(76, 21);
            this.lblTanque2.TabIndex = 17;
            this.lblTanque2.Text = "Tanque 2 ";
            // 
            // lblTanque1
            // 
            this.lblTanque1.AutoSize = true;
            this.lblTanque1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTanque1.Location = new System.Drawing.Point(39, 375);
            this.lblTanque1.Name = "lblTanque1";
            this.lblTanque1.Size = new System.Drawing.Size(72, 21);
            this.lblTanque1.TabIndex = 16;
            this.lblTanque1.Text = "Tanque 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDatos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(146, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 222);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Estación";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Location = new System.Drawing.Point(16, 30);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(45, 25);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Info";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(608, 240);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(117, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // MenuGNS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(833, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grBoxTipoCombustible);
            this.Controls.Add(this.lblTanque3);
            this.Controls.Add(this.lblTanque2);
            this.Controls.Add(this.lblTanque1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MenuGNS";
            this.Text = "MenuGNS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grBoxTipoCombustible.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private GroupBox grBoxTipoCombustible;
        private Button btnSuper;
        private Button btnDiesel;
        private Button btnPremium;
        private Label lblTanque3;
        private Label lblTanque2;
        private Label lblTanque1;
        private GroupBox groupBox2;
        private Label lblDatos;
        private PictureBox pictureBox3;
    }
}