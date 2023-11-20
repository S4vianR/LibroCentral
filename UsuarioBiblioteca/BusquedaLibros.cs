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

namespace UsuarioBiblioteca
{
    public partial class BusquedaLibros : Form
    {
        // Variable de conexion
        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();

        public BusquedaLibros()
        {
            InitializeComponent();

            // Agregar filtros al filtrosBusqueda
            filtroComboBox.Items.Add("Nombre libro");
            filtroComboBox.Items.Add("Autor");
            filtroComboBox.Items.Add("Categoria");

            // categoriasPanel
            categoriasPanel.Visible = false;

            // autorPanel
            autoresPanel.Visible = false;

            // Que las columnas de la tabla se expandan al tamaño del contenido
            tablaResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void agregarCategorias()
        {
            // Agregar categorias al filtro
            // De los libros, la columna estante es la categoria, asi que hacer un query para obtener todas las categorias
            string query = "SELECT DISTINCT estante FROM libros;";
            conexionBD = conexion.conectar();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                categoriasComboBox.DataSource = dt;
                categoriasComboBox.DisplayMember = "estante";
            }

            // Cerrar conexion
            conexion.cerrarConexion(conexionBD);
        }

        private void agregarAutores()
        {
            List<string> autoresList = new List<string>();

            string query = "SELECT DISTINCT primerNombre, primerApellido FROM autores;";
            conexionBD = conexion.conectar();
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    string autor = row["primerNombre"].ToString() + " " + row["primerApellido"].ToString();
                    autoresList.Add(autor);
                }

                // Agregar autores al filtro
                autoresComboBox.DataSource = autoresList;
            }

            // Cerrar conexion
            conexion.cerrarConexion(conexionBD);
        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            string query, texto;

            try
            {
                if (cajaBusqueda.Enabled)
                {
                    texto = cajaBusqueda.Text;
                    query = "SELECT l.ISBN, l.titulo, a.primerNombre, a.primerApellido, l.estante, l.cantidad " +
                            "FROM libros AS l " +
                            "INNER JOIN autores AS a ON a.idAutor = l.idAutor " +
                            "WHERE l.titulo = '" + texto + "'";
                }
                else if (autoresPanel.Visible)
                {
                    texto = autoresComboBox.Text;
                    string[] datosAutor = texto.Split(' ');

                    if (datosAutor.Length >= 2)
                    {
                        string primerNombre = datosAutor[0];
                        string primerApellido = datosAutor[1];

                        query = "SELECT l.ISBN, l.titulo, a.primerNombre, a.primerApellido, l.estante, l.cantidad " +
                                "FROM libros AS l " +
                                "INNER JOIN autores AS a ON a.idAutor = l.idAutor " +
                                "WHERE a.primerNombre = '" + primerNombre + "' AND a.primerApellido = '" + primerApellido + "'";
                    }
                    else
                    {
                        MessageBox.Show("Error al seleccionar el autor", "Error de búsqueda");
                        return;
                    }
                }
                else if (categoriasPanel.Visible)
                {
                    texto = categoriasComboBox.Text;
                    query = "SELECT l.ISBN, l.titulo, a.primerNombre, a.primerApellido, l.estante, l.cantidad " +
                            "FROM libros AS l " +
                            "INNER JOIN autores AS a ON a.idAutor = l.idAutor " +
                            "WHERE l.estante = '" + texto + "'";
                }
                else
                {
                    MessageBox.Show("Error al tomar los datos de búsqueda", "Error de búsqueda");
                    return;
                }

                conexionBD = conexion.conectar();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    tablaResultados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el libro: " + ex.Message, "Error de búsqueda");
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                conexion.cerrarConexion(conexionBD);
                if (conexionBD.State == ConnectionState.Closed)
                {
                    MessageBox.Show("Búsqueda exitosa", "Búsqueda");
                }
            }
        }



        private void filtroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtroComboBox.Text == "Categoria")
            {
                // Agregar categorias al filtro
                agregarCategorias();
                // Habilitar categoriasPanel
                categoriasPanel.Visible = true;
                // Deshabilitar cajaBusqueda
                cajaBusqueda.Enabled = false;
                // Deshabilitar autoresPanel
                autoresPanel.Visible = false;
                // Vaciar lo que tiene autoresComboBox
                autoresComboBox.DataSource = null;
            }
            else if (filtroComboBox.Text == "Nombre libro")
            {
                // Deshabilitar categoriasPanel
                categoriasPanel.Visible = false;
                // Habilitar cajaBusqueda
                cajaBusqueda.Enabled = true;
                // Deshabilitar autoresPanel
                autoresPanel.Visible = false;
                // Vaciar lo que tiene autoresComboBox
                autoresComboBox.DataSource = null;
                // Vaciar lo que tiene categoriasComboBox
                categoriasComboBox.DataSource = null;
            }
            else if (filtroComboBox.Text == "Autor")
            {
                // Agregar autores al filtro
                agregarAutores();
                // Habilitar autoresPanel
                autoresPanel.Visible = true;
                // Deshabilitar cajaBusqueda
                cajaBusqueda.Enabled = false;
                // Deshabilitar categoriasPanel
                categoriasPanel.Visible = false;
                // Vaciar lo que tiene categoriasComboBox
                categoriasComboBox.DataSource = null;
            }
        }
    }
}
