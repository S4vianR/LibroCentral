namespace UsuarioBiblioteca
{
    partial class BusquedaLibros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusquedaLibros));
            this.tablaResultados = new PracticaU2_Componentes.CustomDataGridView();
            this.customLabel1 = new PracticaU2_Componentes.CustomLabel();
            this.cajaBusqueda = new System.Windows.Forms.TextBox();
            this.customButton1 = new PracticaU2_Componentes.CustomButton();
            this.filtroComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autoresPanel = new System.Windows.Forms.Panel();
            this.autoresLabel = new System.Windows.Forms.Label();
            this.autoresComboBox = new System.Windows.Forms.ComboBox();
            this.categoriasPanel = new System.Windows.Forms.Panel();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.categoriasComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.autoresPanel.SuspendLayout();
            this.categoriasPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablaResultados
            // 
            this.tablaResultados.AllowUserToAddRows = false;
            this.tablaResultados.AllowUserToDeleteRows = false;
            this.tablaResultados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaResultados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(112)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaResultados.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablaResultados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.tablaResultados.Location = new System.Drawing.Point(12, 276);
            this.tablaResultados.Name = "tablaResultados";
            this.tablaResultados.ReadOnly = true;
            this.tablaResultados.RowHeadersWidth = 51;
            this.tablaResultados.RowTemplate.Height = 24;
            this.tablaResultados.Size = new System.Drawing.Size(965, 383);
            this.tablaResultados.TabIndex = 0;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.CustomText = null;
            this.customLabel1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(43)))));
            this.customLabel1.Location = new System.Drawing.Point(133, 100);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(177, 37);
            this.customLabel1.TabIndex = 1;
            this.customLabel1.Text = "Bienvenid@";
            // 
            // cajaBusqueda
            // 
            this.cajaBusqueda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cajaBusqueda.Location = new System.Drawing.Point(10, 53);
            this.cajaBusqueda.Name = "cajaBusqueda";
            this.cajaBusqueda.Size = new System.Drawing.Size(194, 22);
            this.cajaBusqueda.TabIndex = 2;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.customButton1.BorderRadius = 20;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(213, 194);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(89, 50);
            this.customButton1.TabIndex = 3;
            this.customButton1.Text = "Buscar";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // filtroComboBox
            // 
            this.filtroComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.filtroComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroComboBox.FormattingEnabled = true;
            this.filtroComboBox.Location = new System.Drawing.Point(272, 53);
            this.filtroComboBox.Name = "filtroComboBox";
            this.filtroComboBox.Size = new System.Drawing.Size(236, 24);
            this.filtroComboBox.TabIndex = 4;
            this.filtroComboBox.SelectedIndexChanged += new System.EventHandler(this.filtroComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Barra de búsqueda";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autoresPanel);
            this.groupBox1.Controls.Add(this.categoriasPanel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.customButton1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cajaBusqueda);
            this.groupBox1.Controls.Add(this.filtroComboBox);
            this.groupBox1.Location = new System.Drawing.Point(455, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Búsqueda";
            // 
            // autoresPanel
            // 
            this.autoresPanel.Controls.Add(this.autoresLabel);
            this.autoresPanel.Controls.Add(this.autoresComboBox);
            this.autoresPanel.Location = new System.Drawing.Point(10, 88);
            this.autoresPanel.Name = "autoresPanel";
            this.autoresPanel.Size = new System.Drawing.Size(246, 100);
            this.autoresPanel.TabIndex = 11;
            // 
            // autoresLabel
            // 
            this.autoresLabel.AutoSize = true;
            this.autoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoresLabel.Location = new System.Drawing.Point(72, 27);
            this.autoresLabel.Name = "autoresLabel";
            this.autoresLabel.Size = new System.Drawing.Size(67, 20);
            this.autoresLabel.TabIndex = 10;
            this.autoresLabel.Text = "Autores";
            // 
            // autoresComboBox
            // 
            this.autoresComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.autoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.autoresComboBox.FormattingEnabled = true;
            this.autoresComboBox.Location = new System.Drawing.Point(7, 50);
            this.autoresComboBox.Name = "autoresComboBox";
            this.autoresComboBox.Size = new System.Drawing.Size(236, 24);
            this.autoresComboBox.TabIndex = 9;
            // 
            // categoriasPanel
            // 
            this.categoriasPanel.Controls.Add(this.categoriaLabel);
            this.categoriasPanel.Controls.Add(this.categoriasComboBox);
            this.categoriasPanel.Location = new System.Drawing.Point(262, 88);
            this.categoriasPanel.Name = "categoriasPanel";
            this.categoriasPanel.Size = new System.Drawing.Size(246, 100);
            this.categoriasPanel.TabIndex = 7;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.AutoSize = true;
            this.categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.Location = new System.Drawing.Point(72, 27);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(90, 20);
            this.categoriaLabel.TabIndex = 10;
            this.categoriaLabel.Text = "Categorias";
            // 
            // categoriasComboBox
            // 
            this.categoriasComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.categoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriasComboBox.FormattingEnabled = true;
            this.categoriasComboBox.Location = new System.Drawing.Point(7, 50);
            this.categoriasComboBox.Name = "categoriasComboBox";
            this.categoriasComboBox.Size = new System.Drawing.Size(236, 24);
            this.categoriasComboBox.TabIndex = 9;
            // 
            // BusquedaLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(989, 671);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.tablaResultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BusquedaLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Búsqueda libros";
            ((System.ComponentModel.ISupportInitialize)(this.tablaResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.autoresPanel.ResumeLayout(false);
            this.autoresPanel.PerformLayout();
            this.categoriasPanel.ResumeLayout(false);
            this.categoriasPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PracticaU2_Componentes.CustomDataGridView tablaResultados;
        private PracticaU2_Componentes.CustomLabel customLabel1;
        private System.Windows.Forms.TextBox cajaBusqueda;
        private PracticaU2_Componentes.CustomButton customButton1;
        private System.Windows.Forms.ComboBox filtroComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel categoriasPanel;
        private System.Windows.Forms.Label categoriaLabel;
        private System.Windows.Forms.ComboBox categoriasComboBox;
        private System.Windows.Forms.Panel autoresPanel;
        private System.Windows.Forms.Label autoresLabel;
        private System.Windows.Forms.ComboBox autoresComboBox;
    }
}

