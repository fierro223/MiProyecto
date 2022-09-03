namespace APPEstacion
{
    partial class Surtidor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Surtidor));
            this.lblPrecio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.lblLts = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnSurtir = new System.Windows.Forms.Button();
            this.lblSeleccionado = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPrecio.Location = new System.Drawing.Point(15, 6);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(155, 32);
            this.lblPrecio.TabIndex = 19;
            this.lblPrecio.Text = "Seleccionado";
            this.lblPrecio.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPesos.Location = new System.Drawing.Point(270, 146);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(252, 41);
            this.lblPesos.TabIndex = 17;
            this.lblPesos.Text = "TOTAL A PAGAR $";
            // 
            // lblLts
            // 
            this.lblLts.AutoSize = true;
            this.lblLts.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLts.Location = new System.Drawing.Point(354, 233);
            this.lblLts.Name = "lblLts";
            this.lblLts.Size = new System.Drawing.Size(113, 41);
            this.lblLts.TabIndex = 16;
            this.lblLts.Text = "LITROS";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(549, 143);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(198, 47);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0";
            // 
            // txtLitros
            // 
            this.txtLitros.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLitros.Location = new System.Drawing.Point(549, 227);
            this.txtLitros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(198, 47);
            this.txtLitros.TabIndex = 14;
            this.txtLitros.Text = "0";
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.IndianRed;
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDetener.Location = new System.Drawing.Point(290, 340);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(201, 55);
            this.btnDetener.TabIndex = 13;
            this.btnDetener.Text = "DETENER";
            this.btnDetener.UseVisualStyleBackColor = false;
            // 
            // btnSurtir
            // 
            this.btnSurtir.BackColor = System.Drawing.Color.Chartreuse;
            this.btnSurtir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSurtir.Location = new System.Drawing.Point(567, 340);
            this.btnSurtir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSurtir.Name = "btnSurtir";
            this.btnSurtir.Size = new System.Drawing.Size(141, 55);
            this.btnSurtir.TabIndex = 12;
            this.btnSurtir.Text = "SURTIR";
            this.btnSurtir.UseVisualStyleBackColor = false;
            // 
            // lblSeleccionado
            // 
            this.lblSeleccionado.AutoSize = true;
            this.lblSeleccionado.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeleccionado.Location = new System.Drawing.Point(30, 426);
            this.lblSeleccionado.Name = "lblSeleccionado";
            this.lblSeleccionado.Size = new System.Drawing.Size(155, 32);
            this.lblSeleccionado.TabIndex = 20;
            this.lblSeleccionado.Text = "Seleccionado";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            // 
            // Surtidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.lblSeleccionado);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblLts);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnSurtir);
            this.Name = "Surtidor";
            this.Text = "Surtidor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPrecio;
        private PictureBox pictureBox1;
        private Label lblPesos;
        private Label lblLts;
        private TextBox txtTotal;
        private TextBox txtLitros;
        private Button btnDetener;
        private Button btnSurtir;
        private Label lblSeleccionado;
        private System.Windows.Forms.Timer timer1;
    }
}