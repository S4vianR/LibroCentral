using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioMaster
{
    public class ConexionSQL
    {
        // Variables
        string host = "raspbian-serv.ddns.net";
        string user = "bibliotecaA";
        string password = "bibliotecaA123";
        string database = "biblioteca";
        string port = "3306";

        // Constructor
        public ConexionSQL()
        {
            // Constructor vacio
        }

        // Metodos
        public MySqlConnection conectar()
        {
            try
            {
                string cadenaConexion = "Database=" + database + "; Data Source=" + host + "; Port=" + port + "; User Id=" + user + "; Password=" + password + ";";
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);
                return conexionBD;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error de conexion");
                return null;
            }
        }

        public void abrirConexion(MySqlConnection conexionBD)
        {
            try
            {
                conexionBD.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al abrir la conexion con la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        public void cerrarConexion(MySqlConnection conexionBD)
        {
            try
            {
                conexionBD.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cerrar la conexion con la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        public void insertar(MySqlConnection conexionBD, string query)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        public void actualizar(MySqlConnection conexionBD, string query)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar datos en la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        public void eliminar(MySqlConnection conexionBD, string query)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al eliminar datos en la base de datos: " + ex.Message, "Error de conexion");
            }
        }

        public MySqlDataReader consultar(MySqlConnection conexionBD, string query)
        {
            try
            {
                if (conexionBD.State == ConnectionState.Closed)
                {
                    conexionBD.Open();
                }

                MySqlCommand comando = new MySqlCommand(query, conexionBD);
                MySqlDataReader consulta = comando.ExecuteReader(CommandBehavior.CloseConnection);
                return consulta;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al consultar datos en la base de datos: " + ex.Message, "Error de conexion");
                return null;
            }
        }

    }
}
