namespace AppBibliotecaria
{
    partial class FRMlectores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMlectores));
            this.lbCORREOLECTOR = new System.Windows.Forms.Label();
            this.lbPRIMERNOMBRE = new System.Windows.Forms.Label();
            this.lbSEGUNDONOMBRE = new System.Windows.Forms.Label();
            this.lbAPPAT = new System.Windows.Forms.Label();
            this.lbAPMAT = new System.Windows.Forms.Label();
            this.lbTELEFONO = new System.Windows.Forms.Label();
            this.tbCORREOLECTOR = new System.Windows.Forms.TextBox();
            this.tbPRIMERNOMBRE = new System.Windows.Forms.TextBox();
            this.tbSEGUNDONOMBRE = new System.Windows.Forms.TextBox();
            this.tbAPPAT = new System.Windows.Forms.TextBox();
            this.tbAPMAT = new System.Windows.Forms.TextBox();
            this.tbTELEFONO = new System.Windows.Forms.TextBox();
            this.BTNRegistrarLector = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCORREOLECTOR
            // 
            this.lbCORREOLECTOR.AutoSize = true;
            this.lbCORREOLECTOR.Location = new System.Drawing.Point(40, 212);
            this.lbCORREOLECTOR.Name = "lbCORREOLECTOR";
            this.lbCORREOLECTOR.Size = new System.Drawing.Size(48, 16);
            this.lbCORREOLECTOR.TabIndex = 0;
            this.lbCORREOLECTOR.Text = "Correo";
            // 
            // lbPRIMERNOMBRE
            // 
            this.lbPRIMERNOMBRE.AutoSize = true;
            this.lbPRIMERNOMBRE.Location = new System.Drawing.Point(40, 39);
            this.lbPRIMERNOMBRE.Name = "lbPRIMERNOMBRE";
            this.lbPRIMERNOMBRE.Size = new System.Drawing.Size(95, 16);
            this.lbPRIMERNOMBRE.TabIndex = 1;
            this.lbPRIMERNOMBRE.Text = "Primer nombre";
            // 
            // lbSEGUNDONOMBRE
            // 
            this.lbSEGUNDONOMBRE.AutoSize = true;
            this.lbSEGUNDONOMBRE.Location = new System.Drawing.Point(40, 73);
            this.lbSEGUNDONOMBRE.Name = "lbSEGUNDONOMBRE";
            this.lbSEGUNDONOMBRE.Size = new System.Drawing.Size(111, 16);
            this.lbSEGUNDONOMBRE.TabIndex = 2;
            this.lbSEGUNDONOMBRE.Text = "Segundo nombre";
            // 
            // lbAPPAT
            // 
            this.lbAPPAT.AutoSize = true;
            this.lbAPPAT.Location = new System.Drawing.Point(40, 107);
            this.lbAPPAT.Name = "lbAPPAT";
            this.lbAPPAT.Size = new System.Drawing.Size(107, 16);
            this.lbAPPAT.TabIndex = 3;
            this.lbAPPAT.Text = "Apellido Paterno";
            // 
            // lbAPMAT
            // 
            this.lbAPMAT.AutoSize = true;
            this.lbAPMAT.Location = new System.Drawing.Point(40, 143);
            this.lbAPMAT.Name = "lbAPMAT";
            this.lbAPMAT.Size = new System.Drawing.Size(109, 16);
            this.lbAPMAT.TabIndex = 4;
            this.lbAPMAT.Text = "Apellido Materno";
            // 
            // lbTELEFONO
            // 
            this.lbTELEFONO.AutoSize = true;
            this.lbTELEFONO.Location = new System.Drawing.Point(40, 181);
            this.lbTELEFONO.Name = "lbTELEFONO";
            this.lbTELEFONO.Size = new System.Drawing.Size(61, 16);
            this.lbTELEFONO.TabIndex = 5;
            this.lbTELEFONO.Text = "Telefono";
            // 
            // tbCORREOLECTOR
            // 
            this.tbCORREOLECTOR.Location = new System.Drawing.Point(198, 206);
            this.tbCORREOLECTOR.MaxLength = 50;
            this.tbCORREOLECTOR.Name = "tbCORREOLECTOR";
            this.tbCORREOLECTOR.Size = new System.Drawing.Size(100, 22);
            this.tbCORREOLECTOR.TabIndex = 6;
            this.tbCORREOLECTOR.TextChanged += new System.EventHandler(this.tbCORREOLECTOR_TextChanged);
            // 
            // tbPRIMERNOMBRE
            // 
            this.tbPRIMERNOMBRE.Location = new System.Drawing.Point(198, 33);
            this.tbPRIMERNOMBRE.MaxLength = 50;
            this.tbPRIMERNOMBRE.Name = "tbPRIMERNOMBRE";
            this.tbPRIMERNOMBRE.Size = new System.Drawing.Size(100, 22);
            this.tbPRIMERNOMBRE.TabIndex = 7;
            this.tbPRIMERNOMBRE.TextChanged += new System.EventHandler(this.tbPRIMERNOMBRE_TextChanged);
            this.tbPRIMERNOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAPMAT_KeyPress);
            // 
            // tbSEGUNDONOMBRE
            // 
            this.tbSEGUNDONOMBRE.Location = new System.Drawing.Point(198, 67);
            this.tbSEGUNDONOMBRE.MaxLength = 50;
            this.tbSEGUNDONOMBRE.Name = "tbSEGUNDONOMBRE";
            this.tbSEGUNDONOMBRE.Size = new System.Drawing.Size(100, 22);
            this.tbSEGUNDONOMBRE.TabIndex = 8;
            this.tbSEGUNDONOMBRE.TextChanged += new System.EventHandler(this.tbSEGUNDONOMBRE_TextChanged);
            this.tbSEGUNDONOMBRE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAPMAT_KeyPress);
            // 
            // tbAPPAT
            // 
            this.tbAPPAT.Location = new System.Drawing.Point(198, 104);
            this.tbAPPAT.MaxLength = 50;
            this.tbAPPAT.Name = "tbAPPAT";
            this.tbAPPAT.Size = new System.Drawing.Size(100, 22);
            this.tbAPPAT.TabIndex = 9;
            this.tbAPPAT.TextChanged += new System.EventHandler(this.tbAPPAT_TextChanged);
            this.tbAPPAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAPMAT_KeyPress);
            // 
            // tbAPMAT
            // 
            this.tbAPMAT.Location = new System.Drawing.Point(198, 137);
            this.tbAPMAT.MaxLength = 50;
            this.tbAPMAT.Name = "tbAPMAT";
            this.tbAPMAT.Size = new System.Drawing.Size(100, 22);
            this.tbAPMAT.TabIndex = 10;
            this.tbAPMAT.TextChanged += new System.EventHandler(this.tbAPMAT_TextChanged);
            this.tbAPMAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAPMAT_KeyPress);
            // 
            // tbTELEFONO
            // 
            this.tbTELEFONO.Location = new System.Drawing.Point(198, 175);
            this.tbTELEFONO.MaxLength = 10;
            this.tbTELEFONO.Name = "tbTELEFONO";
            this.tbTELEFONO.Size = new System.Drawing.Size(100, 22);
            this.tbTELEFONO.TabIndex = 11;
            this.tbTELEFONO.TextChanged += new System.EventHandler(this.tbTELEFONO_TextChanged);
            this.tbTELEFONO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTELEFONO_KeyPress);
            // 
            // BTNRegistrarLector
            // 
            this.BTNRegistrarLector.Location = new System.Drawing.Point(422, 33);
            this.BTNRegistrarLector.Name = "BTNRegistrarLector";
            this.BTNRegistrarLector.Size = new System.Drawing.Size(96, 68);
            this.BTNRegistrarLector.TabIndex = 12;
            this.BTNRegistrarLector.Text = "Registrar Lector";
            this.BTNRegistrarLector.UseVisualStyleBackColor = true;
            this.BTNRegistrarLector.Click += new System.EventHandler(this.BTNRegistrarLector_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(405, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 109);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FRMlectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(614, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNRegistrarLector);
            this.Controls.Add(this.tbTELEFONO);
            this.Controls.Add(this.tbAPMAT);
            this.Controls.Add(this.tbAPPAT);
            this.Controls.Add(this.tbSEGUNDONOMBRE);
            this.Controls.Add(this.tbPRIMERNOMBRE);
            this.Controls.Add(this.tbCORREOLECTOR);
            this.Controls.Add(this.lbTELEFONO);
            this.Controls.Add(this.lbAPMAT);
            this.Controls.Add(this.lbAPPAT);
            this.Controls.Add(this.lbSEGUNDONOMBRE);
            this.Controls.Add(this.lbPRIMERNOMBRE);
            this.Controls.Add(this.lbCORREOLECTOR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMlectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LECTORESFORMA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMmenulectores_FormClosing);
            this.Load += new System.EventHandler(this.FRMmenulectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCORREOLECTOR;
        private System.Windows.Forms.Label lbPRIMERNOMBRE;
        private System.Windows.Forms.Label lbSEGUNDONOMBRE;
        private System.Windows.Forms.Label lbAPPAT;
        private System.Windows.Forms.Label lbAPMAT;
        private System.Windows.Forms.Label lbTELEFONO;
        private System.Windows.Forms.TextBox tbCORREOLECTOR;
        private System.Windows.Forms.TextBox tbPRIMERNOMBRE;
        private System.Windows.Forms.TextBox tbSEGUNDONOMBRE;
        private System.Windows.Forms.TextBox tbAPPAT;
        private System.Windows.Forms.TextBox tbAPMAT;
        private System.Windows.Forms.TextBox tbTELEFONO;
        private System.Windows.Forms.Button BTNRegistrarLector;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}