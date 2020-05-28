using System.Data.SqlClient;

namespace ProjetoGenesys.App.model
{
    class Conexao
    {
        public class SqlServer
        {
            static string sqlServer = @"CAMINHO";
            public static SqlConnection getConnection()
            {
                SqlConnection conn = new SqlConnection(sqlServer);
                return conn;
            }
        }
        public class MySql
        {
            static string mySql = @"CAMINHO";
            public static SqlConnection getConnection()
            {
                SqlConnection conn = new SqlConnection(mySql);
                return conn;
            }
        }
    }
}
