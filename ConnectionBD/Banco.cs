using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConnectionBD
{
    public class Banco
    {
        private readonly MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
        private readonly MySqlCommand cmd = new MySqlCommand();

        public void Open()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public string ExecuteScalarMySql(string Query)
        {
            cmd.CommandText = Query;
            cmd.Connection = connection;
            return cmd.ExecuteScalar().ToString();
        }
        public MySqlDataReader ExecuteReadMySql(string Query)
        {
            cmd.CommandText = Query;
            cmd.Connection = connection;
            return cmd.ExecuteReader();
        }
        public DataTable ExecuteScalarTableMySql(string Query)
        {
            cmd.CommandText = Query;
            cmd.Connection = connection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void ExecuteNonScalarMySql(string Query)
        {
            cmd.CommandText = Query;
            cmd.Connection = connection;
            cmd.ExecuteNonQuery();
        }
        public void Close()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
    }
}
