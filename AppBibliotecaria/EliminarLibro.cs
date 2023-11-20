using InventarioMaster;
using MySqlConnector;
using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String qry;
            if (tbBusqueda.Text == "")
            {
                MessageBox.Show("Ingrese el título del libro a buscar", "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        dataGridView1.DataSource = ds.Tables[0];
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("¿Desea eliminar una de las copias del título buscado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (DialogResult == DialogResult.Yes)
            {
                String qry;

                try
                {
                    conexionBD = conexion.conectar();

                    qry = "UPDATE libros SET cantidad= cantidad-1 WHERE titulo LIKE '" + tbBusqueda.Text + "'"; //Se actualiza la cantidad de libros restando uno
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(qry, conexionBD))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La cantidad de copias disponibles se ha actualizado", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    conexion.cerrarConexion(conexionBD);
                }
            }
            else
            {
                MessageBox.Show("Operación abortada", "Abortar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM libros WHERE titulo LIKE '" + tbBusqueda.Text + "'", conexionBD)) //Se muestra el registro del libro con la actualización en la cantidad
            {
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
