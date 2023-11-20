using InventarioMaster;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBibliotecaria
{
    public partial class FRMLectoreseditar : Form
    {
        private int idLectorSeleccionado = 0;

        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();
        public FRMLectoreseditar()
        {
            InitializeComponent();
        }

        private void Lectoreseditar_Load(object sender, EventArgs e)
        {
            ocultarinterfaz();
            conexionBD = conexion.conectar();
            //string query = "SELECT * FROM lectores";
            string query = "SELECT\r\n    lectores.idLector,\r\n    lectores.primerNombre,\r\n    lectores.segundoNombre,\r\n    lectores.primerApellido,\r\n    lectores.segundoApellido,\r\n    correos_lectores.correo_lector,\r\n    telefonos_lectores.telefono\r\nFROM\r\n    lectores\r\nLEFT JOIN\r\n    correos_lectores ON lectores.idLector = correos_lectores.idLector\r\nLEFT JOIN\r\n    telefonos_lectores ON lectores.idLector = telefonos_lectores.idLector;";


            using (MySqlConnection conexion = new MySqlConnection("conexionBD"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewLectores.DataSource = dataTable;
                }
            }
        }
        private void ocultarinterfaz()
        {
            tbAPMAT.Enabled = false;
            tbAPPAT.Enabled = false;
            tbCORREOLECTOR.Enabled = false;
            tbPRIMERNOMBRE.Enabled = false;
            tbSEGUNDONOMBRE.Enabled = false;
            tbTELEFONO.Enabled = false;
            BTNactualizar.Enabled = false;
            BTNborrar.Enabled = false;
        }
        private void BTNbuscar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            ocultarinterfaz();

            BuscarRegistros(TBbuscar.Text);
            if (TBbuscar.Text == "")
            {
                CargarDatos();
                ocultarinterfaz();
            }
        }
        private void BuscarRegistros(string criterio)
        {
            // Convertir el criterio de búsqueda a minúsculas (o mayúsculas)
            criterio = criterio.ToLower();

            DataTable dataTable = (DataTable)dataGridViewLectores.DataSource;

            var resultados = from row in dataTable.AsEnumerable()
                             let nombreCompleto = $"{row.Field<string>("primerNombre")} {row.Field<string>("segundoNombre")} {row.Field<string>("primerApellido")} {row.Field<string>("segundoApellido")}".ToLower()
                             where nombreCompleto.Contains(criterio) || CoincideConAlMenosUnCampo(row, criterio)
                             //||
                             //row.Field<string>("correo").ToLower().Contains(criterio) ||
                             //row.Field<string>("telefono").ToLower().Contains(criterio)
                             select row;

            if (resultados.Any())
            {
                DataTable resultadoDataTable = resultados.CopyToDataTable();
                dataGridViewLectores.DataSource = resultadoDataTable;
            }
            else
            {
                MessageBox.Show("No se encontraron resultados", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // También puedes considerar cargar todos los datos nuevamente si deseas mostrar todos los registros.
                // CargarDatos(); // Donde CargarDatos() es una función que carga todos los registros en el DataGridView.
            }
        }
        private bool CoincideConAlMenosUnCampo(DataRow row, string criterio)
        {
            // Convertir los datos a minúsculas (o mayúsculas) antes de comparar
            string primerNombre = row.Field<string>("primerNombre").ToLower();
            string segundoNombre = row.Field<string>("segundoNombre").ToLower();
            string primerApellido = row.Field<string>("primerApellido").ToLower();
            string segundoApellido = row.Field<string>("segundoApellido").ToLower();

            // Verificar si el criterio coincide con al menos uno de los campos individuales
            return primerNombre.Contains(criterio) ||
                   segundoNombre.Contains(criterio) ||
                   primerApellido.Contains(criterio) ||
                   segundoApellido.Contains(criterio);
        }
        private void dataGridViewLectores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idLector = 0;
            if (e.RowIndex >= 0)
            {
                // Obtener el ID del lector seleccionado
                idLector = Convert.ToInt32(dataGridViewLectores.Rows[e.RowIndex].Cells["idLector"].Value);
                idLectorSeleccionado = Convert.ToInt32(dataGridViewLectores.Rows[e.RowIndex].Cells["idLector"].Value);
                DataTable dataTable = (DataTable)dataGridViewLectores.DataSource;
                var resultados = from row in dataTable.AsEnumerable()
                                 where row.Field<int>("idLector") == idLector
                                 select row;

                DataRow lectorSeleccionado = resultados.FirstOrDefault();

                // Rellenar los TextBox con los datos del lector, correo y teléfono
                if (lectorSeleccionado != null)
                {
                    tbPRIMERNOMBRE.Text = lectorSeleccionado.Field<string>("primerNombre");
                    tbSEGUNDONOMBRE.Text = lectorSeleccionado.Field<string>("segundoNombre");
                    tbAPPAT.Text = lectorSeleccionado.Field<string>("primerApellido");
                    tbAPMAT.Text = lectorSeleccionado.Field<string>("segundoApellido");
                    tbCORREOLECTOR.Text = lectorSeleccionado.Field<string>("correo_lector");
                    tbTELEFONO.Text = lectorSeleccionado.Field<string>("telefono");
                }

                // Habilitar los TextBox para la edición
                tbPRIMERNOMBRE.Enabled = true;
                tbSEGUNDONOMBRE.Enabled = true;
                tbAPPAT.Enabled = true;
                tbAPMAT.Enabled = true;
                tbCORREOLECTOR.Enabled = true;
                tbTELEFONO.Enabled = true;

                // Habilitar el botón de actualización
                BTNactualizar.Enabled = true;
                BTNborrar.Enabled = true;
            }


        }

        private void BTNborrar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Seguro que desea borrar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {

                if (BorrarLector(idLectorSeleccionado))
                {
                    MessageBox.Show("Registro borrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                }
                else
                {
                    MessageBox.Show("Error al borrar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                ocultarinterfaz();
                CargarDatos();
            }

        }
        private bool BorrarLector(int idLector)
        {
            try
            {
                conexionBD = conexion.conectar();
                conexionBD.Open();

                // Antes de borrar el lector, borra los registros asociados en las otras tablas
                string qryBorrarCorreos = "DELETE FROM correos_lectores WHERE idLector = @IdLector";
                using (MySqlCommand comandoBorrarCorreos = new MySqlCommand(qryBorrarCorreos, conexionBD))
                {
                    comandoBorrarCorreos.Parameters.AddWithValue("@IdLector", idLector);
                    comandoBorrarCorreos.ExecuteNonQuery();
                }

                string qryBorrarTelefonos = "DELETE FROM telefonos_lectores WHERE idLector = @IdLector";
                using (MySqlCommand comandoBorrarTelefonos = new MySqlCommand(qryBorrarTelefonos, conexionBD))
                {
                    comandoBorrarTelefonos.Parameters.AddWithValue("@IdLector", idLector);
                    comandoBorrarTelefonos.ExecuteNonQuery();
                }

                // Ahora, puedes borrar el registro en la tabla lectores
                string qryBorrarLector = "DELETE FROM lectores WHERE idLector = @IdLector";
                using (MySqlCommand comandoBorrarLector = new MySqlCommand(qryBorrarLector, conexionBD))
                {
                    comandoBorrarLector.Parameters.AddWithValue("@IdLector", idLector);
                    comandoBorrarLector.ExecuteNonQuery();
                }

                return true; // Retorna true si se borra correctamente.
            }
            catch (Exception ex)
            {
                // Maneja cualquier excepción que pueda ocurrir durante el borrado.
                MessageBox.Show("Error al borrar el registro: " + ex.Message, "Error de borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                conexion.cerrarConexion(conexionBD);
            }
        }
        private void CargarDatos()
        {

            conexionBD = conexion.conectar();
            //string query = "SELECT * FROM lectores";
            string query = "SELECT\r\n    lectores.idLector,\r\n    lectores.primerNombre,\r\n    lectores.segundoNombre,\r\n    lectores.primerApellido,\r\n    lectores.segundoApellido,\r\n    correos_lectores.correo_lector,\r\n    telefonos_lectores.telefono\r\nFROM\r\n    lectores\r\nLEFT JOIN\r\n    correos_lectores ON lectores.idLector = correos_lectores.idLector\r\nLEFT JOIN\r\n    telefonos_lectores ON lectores.idLector = telefonos_lectores.idLector;";


            using (MySqlConnection conexion = new MySqlConnection("conexionBD"))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conexionBD))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewLectores.DataSource = dataTable;
                }
            }
        }

        private void BTNactualizar_Click(object sender, EventArgs e)
        {
            // Validar si los campos están vacíos
            if (tbPRIMERNOMBRE.Text == "" || tbAPPAT.Text == "" || tbCORREOLECTOR.Text == "" || tbTELEFONO.Text == "")
            {
                // Mostrar mensaje de error
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Función que debes implementar para obtener el ID del lector seleccionado
                if (idLectorSeleccionado > 0)
                {
                    try
                    {
                        conexionBD = conexion.conectar();
                        conexionBD.Open();

                        // Actualizar los datos en la tabla 'lectores'
                        string qryActualizarLector = "UPDATE lectores SET primerNombre = @PrimerNombre, segundoNombre = @SegundoNombre, primerApellido = @PrimerApellido, segundoApellido = @SegundoApellido WHERE idLector = @IdLector";

                        using (MySqlCommand comandoActualizarLector = new MySqlCommand(qryActualizarLector, conexionBD))
                        {
                            comandoActualizarLector.Parameters.AddWithValue("@PrimerNombre", tbPRIMERNOMBRE.Text);
                            comandoActualizarLector.Parameters.AddWithValue("@SegundoNombre", tbSEGUNDONOMBRE.Text);
                            comandoActualizarLector.Parameters.AddWithValue("@PrimerApellido", tbAPPAT.Text);
                            comandoActualizarLector.Parameters.AddWithValue("@SegundoApellido", tbAPMAT.Text);
                            comandoActualizarLector.Parameters.AddWithValue("@IdLector", idLectorSeleccionado);

                            comandoActualizarLector.ExecuteNonQuery();
                        }

                        // Actualizar los datos en la tabla 'correos_lectores'
                        string qryActualizarCorreo = "UPDATE correos_lectores SET correo_lector = @Correo WHERE idLector = @IdLector";

                        using (MySqlCommand comandoActualizarCorreo = new MySqlCommand(qryActualizarCorreo, conexionBD))
                        {
                            comandoActualizarCorreo.Parameters.AddWithValue("@Correo", tbCORREOLECTOR.Text);
                            comandoActualizarCorreo.Parameters.AddWithValue("@IdLector", idLectorSeleccionado);

                            comandoActualizarCorreo.ExecuteNonQuery();
                        }

                        // Actualizar los datos en la tabla 'telefonos_lectores'
                        string qryActualizarTelefono = "UPDATE telefonos_lectores SET telefono = @Telefono WHERE idLector = @IdLector";

                        using (MySqlCommand comandoActualizarTelefono = new MySqlCommand(qryActualizarTelefono, conexionBD))
                        {
                            comandoActualizarTelefono.Parameters.AddWithValue("@Telefono", tbTELEFONO.Text);
                            comandoActualizarTelefono.Parameters.AddWithValue("@IdLector", idLectorSeleccionado);

                            comandoActualizarTelefono.ExecuteNonQuery();
                        }

                        MessageBox.Show("Lector actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ocultarinterfaz();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al actualizar el lector: " + ex.Message, "Error de actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conexion.cerrarConexion(conexionBD);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún lector para actualizar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void FRMLectoreseditar_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                FRMMenulectores ML = new FRMMenulectores();
                this.Hide();
                ML.Show();
            }
        }
    }
}
