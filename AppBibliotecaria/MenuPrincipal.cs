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
    public partial class MenúBiblioteca : Form
    {
        public MenúBiblioteca()
        {
            InitializeComponent();
        }

        private void linklblLibros_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MenúLibros ML= new MenúLibros();
            this.Hide();
            ML.Show();
        }

        private void MenúBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void linklblLectores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FRMMenulectores Menulectores = new FRMMenulectores();
            this.Hide();
            Menulectores.Show();
        }

        private void MenúBiblioteca_Load(object sender, EventArgs e)
        {

        }
    }
}
