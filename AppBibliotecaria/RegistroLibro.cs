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
    public partial class Form3 : Form
    {
        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String qry;
            int idAutor = ObtenerAutor(tbNAutor.Text, tbAAutor.Text);
            if (tbAAutor.Text == "" || tbCantidad.Text == "" || tbEstante.Text == "" || tbIsbn.Text == "" || tbNAutor.Text == "" || tbTitulo.Text == "")
            {
                MessageBox.Show("Faltan campos por llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (idAutor == 0)
                {
                    return;
                }
                else
                {
                    try
                    {
                        conexionBD = conexion.conectar();
                        conexionBD.Open();
                        //Se hace la insercion del libro
                        qry = "INSERT INTO libros (ISBN, titulo, idAutor, estante, cantidad) VALUES (@ISBN, @Titulo, @IdAutor, @Estante, @Cantidad)";

                        using (MySqlCommand comando = new MySqlCommand(qry, conexionBD))
                        {
                            comando.Parameters.AddWithValue("@ISBN", tbIsbn.Text);
                            comando.Parameters.AddWithValue("@Titulo", tbTitulo.Text);
                            comando.Parameters.AddWithValue("@IdAutor", idAutor);
                            comando.Parameters.AddWithValue("@Estante", tbEstante.Text);
                            comando.Parameters.AddWithValue("@Cantidad", tbCantidad.Text);

                            comando.ExecuteNonQuery();
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
                    MessageBox.Show("Libro registrado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public int ObtenerAutor(String nombre, String apellido)
        {
            int idAutor = 0;

            try
            {
                // Obtener el máximo id de la tabla autores para en caso de que el autor no exista crear el registro del nuevo autor
                using (MySqlConnection conexionBDMax = conexion.conectar())
                {
                    conexionBDMax.Open();
                    string consultaMax = "SELECT MAX(idAutor) FROM autores";

                    using (MySqlCommand comandoMax = new MySqlCommand(consultaMax, conexionBDMax))
                    {
                        object resultadoMax = comandoMax.ExecuteScalar();

                        if (resultadoMax != null && resultadoMax != DBNull.Value)
                        {
                            idAutor = Convert.ToInt32(resultadoMax) + 1;
                        }
                    }
                }

                // Verifica si el autor ya existe
                using (MySqlConnection conexionBDExistencia = conexion.conectar())
                {
                    conexionBDExistencia.Open();
                    string qryExistencia = "SELECT idAutor FROM autores WHERE primerNombre LIKE @PrimerNombre AND primerApellido LIKE @PrimerApellido";

                    using (MySqlCommand comandoExistencia = new MySqlCommand(qryExistencia, conexionBDExistencia))
                    {
                        comandoExistencia.Parameters.AddWithValue("@PrimerNombre", nombre);
                        comandoExistencia.Parameters.AddWithValue("@PrimerApellido", apellido);

                        object resultadoExistencia = comandoExistencia.ExecuteScalar();

                        if (resultadoExistencia != null && resultadoExistencia != DBNull.Value)
                        {
                            // Si el autor existe devuelve el id de este
                            idAutor = Convert.ToInt32(resultadoExistencia);
                        }
                        else
                        {
                            // Si el autor no existe, se inserta uno nuevo
                            using (MySqlConnection conexionBDInsercion = conexion.conectar())
                            {
                                conexionBDInsercion.Open();
                                string consultaInsercion = "INSERT INTO autores (idAutor, primerNombre, segundoNombre, primerApellido, segundoApellido) VALUES (@IdAutor, @PrimerNombre, '', @PrimerApellido, '')";

                                using (MySqlCommand comandoInsercion = new MySqlCommand(consultaInsercion, conexionBDInsercion))
                                {
                                    comandoInsercion.Parameters.AddWithValue("@IdAutor", idAutor);
                                    comandoInsercion.Parameters.AddWithValue("@PrimerNombre", nombre);
                                    comandoInsercion.Parameters.AddWithValue("@PrimerApellido", apellido);

                                    // Se hace la inserción
                                    comandoInsercion.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar la consulta: " + ex.Message, "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idAutor;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
