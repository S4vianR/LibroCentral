using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBibliotecaria
{
    public partial class MenúLibros : Form
    {
        public MenúLibros()
        {
            InitializeComponent();
        }

        private void MenúBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MenúBiblioteca MB = new MenúBiblioteca();
                this.Hide();
                MB.Show();
            }

        }

        private void linklblConsultaL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenúLibros FM= new MenúLibros();
            BuscarLibro F1 = new BuscarLibro();
            FM.Hide();
            F1.Show();
        }

        private void linklblEliminarL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenúLibros FM = new MenúLibros();
            Form2 F2= new Form2();
            FM.Hide();
            F2.Show();
        }

        private void linklblAgregarL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenúLibros FM = new MenúLibros();
            Form3 F3= new Form3();
            FM.Hide();
            F3.Show();
        }

        private void linklblSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MenúBiblioteca MB= new MenúBiblioteca();
                this.Hide();
                MB.Show();
            }
        }

        private void MenúLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
