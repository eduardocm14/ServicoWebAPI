using MySql.Data.MySqlClient;
using System.Data;

namespace ServicoWebAPI.Util
{
    public class DAL
    {
        // Data Access Layer
        private static readonly string Server = "127.0.0.1";
        private static readonly string Database = "dbcliente";
        private static readonly string User = "root";
        private static readonly string Password = "mariadb159753";
        private readonly string ConnectionString = $"Server={Server};Database={Database};Uid={User};Pwd={Password};Sslmode=none;charset=utf8;";
        private readonly MySqlConnection Connection;

        public DAL()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        // Executar: INSERT, UPDATE e DELETE
        public void ExecutarInsertUpDateDelete(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        // Retornar Dados do Banco
        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdapter = new MySqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdapter.Fill(Dados);

            return Dados;
        }
    }
}
