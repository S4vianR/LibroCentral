using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBibliotecaria
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
      public static FRMlectores formalectores = null;
      public static FRMMenulectores Menulectores = null;
        public static void solonumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan numeros");
            }
        }
        public static void sololetras(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se aceptan Caracteres");
            }
        }
        [STAThread]
        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenúBiblioteca());
        }
    }
}
