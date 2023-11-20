namespace AppBibliotecaria
{
    partial class FRMMenulectores
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
            this.btnIRLECTORNUEVO = new System.Windows.Forms.Button();
            this.btnIRCAMBIOS = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIRLECTORNUEVO
            // 
            this.btnIRLECTORNUEVO.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnIRLECTORNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIRLECTORNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIRLECTORNUEVO.Location = new System.Drawing.Point(361, 194);
            this.btnIRLECTORNUEVO.Name = "btnIRLECTORNUEVO";
            this.btnIRLECTORNUEVO.Size = new System.Drawing.Size(197, 95);
            this.btnIRLECTORNUEVO.TabIndex = 0;
            this.btnIRLECTORNUEVO.Text = "Registrar un Lector";
            this.btnIRLECTORNUEVO.UseVisualStyleBackColor = false;
            this.btnIRLECTORNUEVO.Click += new System.EventHandler(this.btnIRLECTORNUEVO_Click);
            // 
            // btnIRCAMBIOS
            // 
            this.btnIRCAMBIOS.BackColor = System.Drawing.Color.SkyBlue;
            this.btnIRCAMBIOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIRCAMBIOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.btnIRCAMBIOS.Location = new System.Drawing.Point(85, 194);
            this.btnIRCAMBIOS.Name = "btnIRCAMBIOS";
            this.btnIRCAMBIOS.Size = new System.Drawing.Size(197, 95);
            this.btnIRCAMBIOS.TabIndex = 1;
            this.btnIRCAMBIOS.Text = "Modificar o eliminar un Lector";
            this.btnIRCAMBIOS.UseVisualStyleBackColor = false;
            this.btnIRCAMBIOS.Click += new System.EventHandler(this.btnIRCAMBIOS_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(361, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 107);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(85, 55);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 107);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // FRMMenulectores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(681, 360);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIRCAMBIOS);
            this.Controls.Add(this.btnIRLECTORNUEVO);
            this.Name = "FRMMenulectores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Lectores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMMenulectores_FormClosing);
            this.Load += new System.EventHandler(this.FRMMenulectores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIRLECTORNUEVO;
        private System.Windows.Forms.Button btnIRCAMBIOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}