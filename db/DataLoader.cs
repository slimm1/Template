using MySql.Data.MySqlClient;
using StandardTemplate.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardTemplate.db
{
    internal class DataLoader
    {
        /// <summary>
        /// El conector encargado de validar la conexion con la base de datos.
        /// </summary>
        private DataConnector connector;
        /// <summary>
        /// Instancia única de esta clase inicializada utilizando el patrón singleton.
        /// </summary>
        public static DataLoader _instance = new DataLoader();

        /// <summary>
        /// Constructor privado para prevenir instancias de <see cref="DbLoader"/>.
        /// </summary>
        private DataLoader()
        {
        }
        /// <summary>
        /// Carga la lista de raperos a través de la consulta en parámetros.
        /// </summary>
        public void LoadRapperList(string query)
        {
            connector = new DataConnector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //rappers.AddRapper(new Rapper(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(4)));
                    }
                }
            }
        }

        /// <summary>
        /// Lee el resultado de una determinada consulta y carga una lista con los resultados.
        /// </summary>
        /// <param name="cmd">Comando sql</param>
        /// <returns>lista de objetos </returns>
        public List<Sample> LoadQueryFromDatabase(string query)
        {
            List<Sample> queryList = new List<Sample>();
            connector = new DataConnector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //queryList.Add(new Rapper(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDouble(4)));
                    }
                }
            }
            return queryList;
        }

        /// <summary>
        /// Guarda el objeto pasado por parámetros en la base de datos.
        /// </summary>
        /// <param name="rapper">El objeto que se va a almacenar</param>
        public void SaveItemInDatabase(Sample sample)
        {
            connector = new DataConnector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                /*cmd.CommandText = $"INSERT INTO Rappers(name, label, subgenre, value) " +
                    $"VALUES ('{rapper.Name}','{rapper.Label}','{rapper.subGenre}','{rapper.marketVal}');";*/
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Actualiza en la base de datos el objeto con los mismo datos que el rapero pasado por parámetros.
        /// </summary>
        /// <param name="r">objeto ya actualiado en memoria</param>
        public void UpdateRapperInDatabase(Sample sample)
        {
            connector = new DataConnector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                /*cmd.CommandText = $"UPDATE Rappers SET name = '{r.Name}', " +
                    $"label = '{r.Label}', subgenre = '{r.subGenre}', value = '{r.marketVal}'" +
                    $"WHERE id = {r.Id};";*/
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Elimina de la base de datos el objeto que coincida con el recibido en los parámetros.
        /// </summary>
        /// <param name="r">El objeto que queremos eliminar</param>
        public void RemoveRapperInDatabase(Sample sample)
        {
            connector = new DataConnector();
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                //cmd.CommandText = $"DELETE FROM Rappers WHERE id = {r.Id}";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
