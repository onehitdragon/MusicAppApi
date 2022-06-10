using System.Data;
using MySql.Data.MySqlClient;

namespace DB{
    public class DataBaseTool{
        private readonly string connectionStrNoDB = "Server=localhost;Database=;Uid=root;CharSet=utf8;";
        private readonly string connectionStr = "Server=localhost;Database=musicapp;Uid=root;CharSet=utf8;";

        public void ExcuteQuery(string query){
            MySqlConnection connect = new MySqlConnection(connectionStr);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public void ExcuteQueryNonDB(string query){   
            MySqlConnection connect = new MySqlConnection(connectionStrNoDB);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        public DataTable GetDataTable(string query){
            MySqlConnection connect = new MySqlConnection(connectionStr);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand(query, connect);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            connect.Close();

            return tb;
        }
    }
}