using InventarioMaster;
using MySqlConnector;
using System;
using System.Windows.Forms;

namespace AppBibliotecaria
{
    public partial class FRMlectores : Form
    {
        ConexionSQL conexion = new ConexionSQL();
        MySqlConnection conexionBD = new MySqlConnection();
        public FRMlectores()
        {
            InitializeComponent();
            Program.formalectores = this;
        }

        private void FRMmenulectores_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {

                FRMMenulectores ML = new FRMMenulectores();
                this.Hide();
                ML.Show();
            }
        }

        private void FRMmenulectores_Load(object sender, EventArgs e)
        {
            BTNRegistrarLector.Enabled = false;
        }

        private void BTNRegistrarLector_Click(object sender, EventArgs e)
        {
            if (tbAPMAT.Text == ""
                || tbAPPAT.Text == ""
                || tbCORREOLECTOR.Text == ""
                || tbPRIMERNOMBRE.Text == ""
                || tbSEGUNDONOMBRE.Text == ""
                || tbTELEFONO.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (LectorExiste(tbPRIMERNOMBRE.Text, tbSEGUNDONOMBRE.Text, tbAPPAT.Text, tbAPMAT.Text))
                {
                    MessageBox.Show("El lector ya existe en la base de datos.", "Lector Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    conexionBD = conexion.conectar();
                    conexionBD.Open();

                    // Insertar en la tabla 'lectores'
                    string qryInsertarLector = "INSERT INTO lectores (primerNombre, segundoNombre, primerApellido, segundoApellido) VALUES (@PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido)";

                    using (MySqlCommand comandoInsertarLector = new MySqlCommand(qryInsertarLector, conexionBD))
                    {
                        comandoInsertarLector.Parameters.AddWithValue("@PrimerNombre", tbPRIMERNOMBRE.Text);
                        comandoInsertarLector.Parameters.AddWithValue("@SegundoNombre", tbSEGUNDONOMBRE.Text);
                        comandoInsertarLector.Parameters.AddWithValue("@PrimerApellido", tbAPPAT.Text);
                        comandoInsertarLector.Parameters.AddWithValue("@SegundoApellido", tbAPMAT.Text);

                        comandoInsertarLector.ExecuteNonQuery();
                    }

                    // Obtener el ID del último lector insertado
                    int idLector;
                    string qryObtenerIdLector = "SELECT LAST_INSERT_ID()";

                    using (MySqlCommand comandoObtenerIdLector = new MySqlCommand(qryObtenerIdLector, conexionBD))
                    {
                        idLector = Convert.ToInt32(comandoObtenerIdLector.ExecuteScalar());
                    }

                    // Insertar en la tabla 'correo_lector'
                    string qryInsertarCorreo = "INSERT INTO correos_lectores (idLector, correo_lector) VALUES (@IdLector, @Correo)";

                    using (MySqlCommand comandoInsertarCorreo = new MySqlCommand(qryInsertarCorreo, conexionBD))
                    {
                        comandoInsertarCorreo.Parameters.AddWithValue("@IdLector", idLector);
                        comandoInsertarCorreo.Parameters.AddWithValue("@Correo", tbCORREOLECTOR.Text);

                        comandoInsertarCorreo.ExecuteNonQuery();
                    }

                    // Insertar en la tabla 'telefono'
                    string qryInsertarTelefono = "INSERT INTO telefonos_lectores (idLector, telefono) VALUES (@IdLector, @Telefono)";

                    using (MySqlCommand comandoInsertarTelefono = new MySqlCommand(qryInsertarTelefono, conexionBD))
                    {
                        comandoInsertarTelefono.Parameters.AddWithValue("@IdLector", idLector);
                        comandoInsertarTelefono.Parameters.AddWithValue("@Telefono", tbTELEFONO.Text);

                        comandoInsertarTelefono.ExecuteNonQuery();
                    }

                    MessageBox.Show("Lector registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiartextbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar al lector: " + ex.Message, "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conexion.cerrarConexion(conexionBD);
                    limpiartextbox();
                }
            }
        }
        private bool LectorExiste(string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            try
            {
                conexionBD = conexion.conectar();
                conexionBD.Open();

                string qryVerificarExistencia = "SELECT COUNT(*) FROM lectores WHERE primerNombre = @PrimerNombre AND segundoNombre = @SegundoNombre AND primerApellido = @PrimerApellido AND segundoApellido = @SegundoApellido";

                using (MySqlCommand comandoVerificarExistencia = new MySqlCommand(qryVerificarExistencia, conexionBD))
                {
                    comandoVerificarExistencia.Parameters.AddWithValue("@PrimerNombre", primerNombre);
                    comandoVerificarExistencia.Parameters.AddWithValue("@SegundoNombre", segundoNombre);
                    comandoVerificarExistencia.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                    comandoVerificarExistencia.Parameters.AddWithValue("@SegundoApellido", segundoApellido);

                    int cantidadLectores = Convert.ToInt32(comandoVerificarExistencia.ExecuteScalar());

                    return cantidadLectores > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar la existencia del lector: " + ex.Message, "Error de verificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Tratar como que el lector existe para evitar la inserción accidental
            }
            finally
            {
                conexion.cerrarConexion(conexionBD);
            }
        }
        public void limpiartextbox()
        {

            tbAPMAT.Clear();
            tbAPPAT.Clear();
            tbCORREOLECTOR.Clear();
            tbPRIMERNOMBRE.Clear();
            tbSEGUNDONOMBRE.Clear();
            tbTELEFONO.Clear();


            BTNRegistrarLector.Enabled = false;
        }
        private void tbAPMAT_TextChanged(object sender, EventArgs e)
        {
            checardatos();
        }

        private void tbAPPAT_TextChanged(object sender, EventArgs e)
        {
            checardatos();
        }
        public void checardatos()
        {
            if (tbAPMAT.Text != ""
                  && tbAPPAT.Text != ""
                  && tbCORREOLECTOR.Text != ""
                  && tbPRIMERNOMBRE.Text != ""
                  && tbSEGUNDONOMBRE.Text != ""
                  && tbTELEFONO.Text != "")
            {
                BTNRegistrarLector.Enabled = true;
            }
            else
            {
                BTNRegistrarLector.Enabled = false;
            }
        }

        private void tbSEGUNDONOMBRE_TextChanged(object sender, EventArgs e)
        {
            checardatos();
        }

        private void tbPRIMERNOMBRE_TextChanged(object sender, EventArgs e)
        {
            checardatos();
        }

        private void tbCORREOLECTOR_TextChanged(object sender, EventArgs e)
        {
            checardatos();

        }

        private void tbTELEFONO_TextChanged(object sender, EventArgs e)
        {
            checardatos();

        }

        private void tbAPMAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.sololetras(sender, e);
        }

        private void tbTELEFONO_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.solonumeros(sender, e);
        }
    }
}
