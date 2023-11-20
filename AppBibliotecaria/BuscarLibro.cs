using InventarioMaster;
using MySqlConnector;
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
    public partial class BuscarLibro : Form
    {
        // Variables
        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();
        public BuscarLibro()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Variables
            string query;

            try
            {
                // Inicializar conexion
                conexionBD = conexion.conectar();

                // Query
                query = "SELECT * FROM libros";

                // Ejecutar query
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error de consulta");
            }
            finally
            {
                // Cerrar conexion
                conexion.cerrarConexion(conexionBD);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String qry;
            if (tbBusqueda.Text == "")
            {
                MessageBox.Show("No se ha ingresado ningún dato.", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    conexionBD = conexion.conectar();

                    qry = "SELECT * FROM libros WHERE titulo LIKE '" + tbBusqueda.Text + "'"; //Busca el libro para hacer la actualización en la cantidad

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(qry, conexionBD))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView2.DataSource = ds.Tables[0];
                        if (ds.Tables[0].Rows.Count == 0)
                        {
                            MessageBox.Show("No se encontraron coincidencias.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.cerrarConexion(conexionBD);
                }
            }
        }
    }
}
