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
    public partial class FRMMenulectores : Form
    {
        public FRMMenulectores()
        {
            InitializeComponent();
            Program.Menulectores = this;
        }

        private void FRMMenulectores_Load(object sender, EventArgs e)
        {

        }

        private void btnIRLECTORNUEVO_Click(object sender, EventArgs e)
        {
            FRMlectores Lectores = new FRMlectores();
            this.Hide();
            Lectores.Show();
        }

        private void btnIRCAMBIOS_Click(object sender, EventArgs e)
        {
            FRMLectoreseditar editarlectores = new FRMLectoreseditar();
            this.Hide();
            editarlectores.Show();
        }

        private void FRMMenulectores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MenúBiblioteca MB = new MenúBiblioteca();
                this.Hide();
                MB.Show();
            }
        }
    }
}
