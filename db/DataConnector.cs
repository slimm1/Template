using MySql.Data.MySqlClient;
using StandardTemplate.utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StandardTemplate.db
{
    internal class DataConnector
    {
        /// <summary>
        /// string de conexion
        /// </summary>
        private string connectionString;
        /// <summary>
        /// objeto conector
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// Inicia una nueva instancia de <see cref="DataConnector"/> a través de las constantes definidas para la base de datos.
        /// </summary>
        public DataConnector()
        {
            connectionString = $"server={AppConstants.HOST}; port={AppConstants.PORT}; uid={AppConstants.USER}; " +
                $"pwd={AppConstants.PASSWORD}; database={AppConstants.DATABASE}";
            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Devuelve la conexion si no ha habido excepciones. De lo contrario lanza un mensaje de advertencia.
        /// </summary>
        /// <returns></returns>
        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return connection;
        }
    }
}
