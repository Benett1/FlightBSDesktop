using MySql.Data.MySqlClient;

namespace FBS.DAL
{
    internal class SqlConnection
    {
        public static MySqlConnection GetSQLCnn()
        {
            return new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));
        }
    }
}
