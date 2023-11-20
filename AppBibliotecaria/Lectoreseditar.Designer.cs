namespace AppBibliotecaria
{
    partial class FRMLectoreseditar
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
            this.dataGridViewLectores = new System.Windows.Forms.DataGridView();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.tbTELEFONO = new System.Windows.Forms.TextBox();
            this.tbAPMAT = new System.Windows.Forms.TextBox();
            this.tbAPPAT = new System.Windows.Forms.TextBox();
            this.tbSEGUNDONOMBRE = new System.Windows.Forms.TextBox();
            this.tbPRIMERNOMBRE = new System.Windows.Forms.TextBox();
            this.tbCORREOLECTOR = new System.Windows.Forms.TextBox();
            this.lbTELEFONO = new System.Windows.Forms.Label();
            this.lbAPMAT = new System.Windows.Forms.Label();
            this.lbAPPAT = new System.Windows.Forms.Label();
            this.lbSEGUNDONOMBRE = new System.Windows.Forms.Label();
            this.lbPRIMERNOMBRE = new System.Windows.Forms.Label();
            this.lbCORREOLECTOR = new System.Windows.Forms.Label();
            this.TBbuscar = new System.Windows.Forms.TextBox();
            this.BTNbuscar = new System.Windows.Forms.Button();
            this.BTNactualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLectores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewLectores
            // 
            this.dataGridViewLectores.AllowUserToAddRows = false;
            this.dataGridViewLectores.AllowUserToDeleteRows = false;
            this.dataGridViewLectores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLectores.Location = new System.Drawing.Point(12, 186);
            this.dataGridViewLectores.Name = "dataGridViewLectores";
            this.dataGridViewLectores.ReadOnly = true;
            this.dataGridViewLectores.RowHeadersWidth = 51;
            this.dataGridViewLectores.RowTemplate.Height = 24;
            this.dataGridViewLectores.Size = new System.Drawing.Size(1066, 252);
            this.dataGridViewLectores.TabIndex = 0;
            this.dataGridViewLectores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLectores_CellClick);
            // 
            // BTNborrar
            // 
            this.BTNborrar.BackColor = System.Drawing.Color.Tomato;
            this.BTNborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNborrar.Location = new System.Drawing.Point(657, 12);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(116, 55);
            this.BTNborrar.TabIndex = 1;
            this.BTNborrar.Text = "Eliminar";
            this.BTNborrar.UseVisualStyleBackColor = false;
            this.BTNborrar.Click += new System.EventHandler(this.BTNborrar_Click);
            // 
            // tbTELEFONO
            // 
            this.tbTELEFONO.Location = new System.Drawing.Point(170, 92);
            this.tbTELEFONO.MaxLength = 10;
            this.tbTELEFONO.Name = "tbTELEFONO";
            this.tbTELEFONO.Size = new System.Drawing.Size(100, 22);
            this.tbTELEFONO.TabIndex = 23;
            // 
            // tbAPMAT
            // 
            this.tbAPMAT.Location = new System.Drawing.Point(457, 55);
            this.tbAPMAT.MaxLength = 50;
            this.tbAPMAT.Name = "tbAPMAT";
            this.tbAPMAT.Size = new System.Drawing.Size(100, 22);
            this.tbAPMAT.TabIndex = 22;
            // 
            // tbAPPAT
            // 
            this.tbAPPAT.Location = new System.Drawing.Point(457, 22);
            this.tbAPPAT.MaxLength = 50;
            this.tbAPPAT.Name = "tbAPPAT";
            this.tbAPPAT.Size = new System.Drawing.Size(100, 22);
            this.tbAPPAT.TabIndex = 21;
            // 
            // tbSEGUNDONOMBRE
            // 
            this.tbSEGUNDONOMBRE.Location = new System.Drawing.Point(170, 56);
            this.tbSEGUNDONOMBRE.MaxLength = 50;
            this.tbSEGUNDONOMBRE.Name = "tbSEGUNDONOMBRE";
            this.tbSEGUNDONOMBRE.Size = new System.Drawing.Size(100, 22);
            this.tbSEGUNDONOMBRE.TabIndex = 20;
            // 
            // tbPRIMERNOMBRE
            // 
            this.tbPRIMERNOMBRE.Location = new System.Drawing.Point(170, 22);
            this.tbPRIMERNOMBRE.MaxLength = 50;
            this.tbPRIMERNOMBRE.Name = "tbPRIMERNOMBRE";
            this.tbPRIMERNOMBRE.Size = new System.Drawing.Size(100, 22);
            this.tbPRIMERNOMBRE.TabIndex = 19;
            // 
            // tbCORREOLECTOR
            // 
            this.tbCORREOLECTOR.Location = new System.Drawing.Point(457, 92);
            this.tbCORREOLECTOR.MaxLength = 50;
            this.tbCORREOLECTOR.Name = "tbCORREOLECTOR";
            this.tbCORREOLECTOR.Size = new System.Drawing.Size(100, 22);
            this.tbCORREOLECTOR.TabIndex = 18;
            // 
            // lbTELEFONO
            // 
            this.lbTELEFONO.AutoSize = true;
            this.lbTELEFONO.Location = new System.Drawing.Point(12, 98);
            this.lbTELEFONO.Name = "lbTELEFONO";
            this.lbTELEFONO.Size = new System.Drawing.Size(61, 16);
            this.lbTELEFONO.TabIndex = 17;
            this.lbTELEFONO.Text = "Telefono";
            // 
            // lbAPMAT
            // 
            this.lbAPMAT.AutoSize = true;
            this.lbAPMAT.Location = new System.Drawing.Point(299, 61);
            this.lbAPMAT.Name = "lbAPMAT";
            this.lbAPMAT.Size = new System.Drawing.Size(109, 16);
            this.lbAPMAT.TabIndex = 16;
            this.lbAPMAT.Text = "Apellido Materno";
            // 
            // lbAPPAT
            // 
            this.lbAPPAT.AutoSize = true;
            this.lbAPPAT.Location = new System.Drawing.Point(299, 25);
            this.lbAPPAT.Name = "lbAPPAT";
            this.lbAPPAT.Size = new System.Drawing.Size(107, 16);
            this.lbAPPAT.TabIndex = 15;
            this.lbAPPAT.Text = "Apellido Paterno";
            // 
            // lbSEGUNDONOMBRE
            // 
            this.lbSEGUNDONOMBRE.AutoSize = true;
            this.lbSEGUNDONOMBRE.Location = new System.Drawing.Point(12, 62);
            this.lbSEGUNDONOMBRE.Name = "lbSEGUNDONOMBRE";
            this.lbSEGUNDONOMBRE.Size = new System.Drawing.Size(111, 16);
            this.lbSEGUNDONOMBRE.TabIndex = 14;
            this.lbSEGUNDONOMBRE.Text = "Segundo nombre";
            // 
            // lbPRIMERNOMBRE
            // 
            this.lbPRIMERNOMBRE.AutoSize = true;
            this.lbPRIMERNOMBRE.Location = new System.Drawing.Point(12, 28);
            this.lbPRIMERNOMBRE.Name = "lbPRIMERNOMBRE";
            this.lbPRIMERNOMBRE.Size = new System.Drawing.Size(95, 16);
            this.lbPRIMERNOMBRE.TabIndex = 13;
            this.lbPRIMERNOMBRE.Text = "Primer nombre";
            // 
            // lbCORREOLECTOR
            // 
            this.lbCORREOLECTOR.AutoSize = true;
            this.lbCORREOLECTOR.Location = new System.Drawing.Point(299, 98);
            this.lbCORREOLECTOR.Name = "lbCORREOLECTOR";
            this.lbCORREOLECTOR.Size = new System.Drawing.Size(48, 16);
            this.lbCORREOLECTOR.TabIndex = 12;
            this.lbCORREOLECTOR.Text = "Correo";
            // 
            // TBbuscar
            // 
            this.TBbuscar.Location = new System.Drawing.Point(15, 147);
            this.TBbuscar.Name = "TBbuscar";
            this.TBbuscar.Size = new System.Drawing.Size(188, 22);
            this.TBbuscar.TabIndex = 24;
            // 
            // BTNbuscar
            // 
            this.BTNbuscar.BackColor = System.Drawing.Color.PaleGreen;
            this.BTNbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNbuscar.Location = new System.Drawing.Point(231, 143);
            this.BTNbuscar.Name = "BTNbuscar";
            this.BTNbuscar.Size = new System.Drawing.Size(116, 26);
            this.BTNbuscar.TabIndex = 25;
            this.BTNbuscar.Text = "Buscar";
            this.BTNbuscar.UseVisualStyleBackColor = false;
            this.BTNbuscar.Click += new System.EventHandler(this.BTNbuscar_Click);
            // 
            // BTNactualizar
            // 
            this.BTNactualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.BTNactualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNactualizar.Location = new System.Drawing.Point(657, 73);
            this.BTNactualizar.Name = "BTNactualizar";
            this.BTNactualizar.Size = new System.Drawing.Size(116, 55);
            this.BTNactualizar.TabIndex = 26;
            this.BTNactualizar.Text = "Actualizar";
            this.BTNactualizar.UseVisualStyleBackColor = false;
            this.BTNactualizar.Click += new System.EventHandler(this.BTNactualizar_Click);
            // 
            // FRMLectoreseditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(198)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.BTNactualizar);
            this.Controls.Add(this.BTNbuscar);
            this.Controls.Add(this.TBbuscar);
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
            this.Controls.Add(this.BTNborrar);
            this.Controls.Add(this.dataGridViewLectores);
            this.Name = "FRMLectoreseditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lectores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMLectoreseditar_FormClosing);
            this.Load += new System.EventHandler(this.Lectoreseditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLectores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLectores;
        private System.Windows.Forms.Button BTNborrar;
        private System.Windows.Forms.TextBox tbTELEFONO;
        private System.Windows.Forms.TextBox tbAPMAT;
        private System.Windows.Forms.TextBox tbAPPAT;
        private System.Windows.Forms.TextBox tbSEGUNDONOMBRE;
        private System.Windows.Forms.TextBox tbPRIMERNOMBRE;
        private System.Windows.Forms.TextBox tbCORREOLECTOR;
        private System.Windows.Forms.Label lbTELEFONO;
        private System.Windows.Forms.Label lbAPMAT;
        private System.Windows.Forms.Label lbAPPAT;
        private System.Windows.Forms.Label lbSEGUNDONOMBRE;
        private System.Windows.Forms.Label lbPRIMERNOMBRE;
        private System.Windows.Forms.Label lbCORREOLECTOR;
        private System.Windows.Forms.TextBox TBbuscar;
        private System.Windows.Forms.Button BTNbuscar;
        private System.Windows.Forms.Button BTNactualizar;
    }
}