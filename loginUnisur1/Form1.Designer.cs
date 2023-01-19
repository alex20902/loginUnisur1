namespace loginUnisur1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aviso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.tbuser = new System.Windows.Forms.TextBox();
            this.tbcontrasena = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(60, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 231);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(466, 64);
            this.label1.MaximumSize = new System.Drawing.Size(50, 50);
            this.label1.MinimumSize = new System.Drawing.Size(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = ".........LOGIN.........";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(356, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "USUARIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(356, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONTRASEÑA";
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Location = new System.Drawing.Point(169, 342);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(10, 13);
            this.aviso.TabIndex = 4;
            this.aviso.Text = "-";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(681, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.salir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.salir.Location = new System.Drawing.Point(681, 212);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(97, 47);
            this.salir.TabIndex = 6;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbuser
            // 
            this.tbuser.Location = new System.Drawing.Point(418, 151);
            this.tbuser.Name = "tbuser";
            this.tbuser.Size = new System.Drawing.Size(186, 20);
            this.tbuser.TabIndex = 7;
            // 
            // tbcontrasena
            // 
            this.tbcontrasena.Location = new System.Drawing.Point(443, 243);
            this.tbcontrasena.Name = "tbcontrasena";
            this.tbcontrasena.Size = new System.Drawing.Size(167, 20);
            this.tbcontrasena.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbcontrasena);
            this.Controls.Add(this.tbuser);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.aviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox tbuser;
        private System.Windows.Forms.TextBox tbcontrasena;
    }
}

