namespace AppBibliotecaria
{
    partial class MenúBiblioteca
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
            this.linklblLibros = new System.Windows.Forms.LinkLabel();
            this.linklblLectores = new System.Windows.Forms.LinkLabel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linklblLibros
            // 
            this.linklblLibros.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.linklblLibros.AutoSize = true;
            this.linklblLibros.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLibros.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblLibros.LinkColor = System.Drawing.Color.Black;
            this.linklblLibros.Location = new System.Drawing.Point(292, 181);
            this.linklblLibros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblLibros.Name = "linklblLibros";
            this.linklblLibros.Size = new System.Drawing.Size(81, 29);
            this.linklblLibros.TabIndex = 10;
            this.linklblLibros.TabStop = true;
            this.linklblLibros.Text = "Libros";
            this.linklblLibros.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklblLibros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLibros_LinkClicked);
            // 
            // linklblLectores
            // 
            this.linklblLectores.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.linklblLectores.AutoSize = true;
            this.linklblLectores.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblLectores.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linklblLectores.LinkColor = System.Drawing.Color.Black;
            this.linklblLectores.Location = new System.Drawing.Point(280, 265);
            this.linklblLectores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklblLectores.Name = "linklblLectores";
            this.linklblLectores.Size = new System.Drawing.Size(108, 29);
            this.linklblLectores.TabIndex = 9;
            this.linklblLectores.TabStop = true;
            this.linklblLectores.Text = "Lectores";
            this.linklblLectores.VisitedLinkColor = System.Drawing.Color.Red;
            this.linklblLectores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLectores_LinkClicked);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Navy;
            this.lbl1.Location = new System.Drawing.Point(209, 49);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(257, 48);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "BiblioTECNM.";
            // 
            // MenúBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(693, 370);
            this.Controls.Add(this.linklblLibros);
            this.Controls.Add(this.linklblLectores);
            this.Controls.Add(this.lbl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenúBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Biblioteca.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenúBiblioteca_FormClosing);
            this.Load += new System.EventHandler(this.MenúBiblioteca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linklblLibros;
        private System.Windows.Forms.LinkLabel linklblLectores;
        private System.Windows.Forms.Label lbl1;
    }
}