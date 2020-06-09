using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace ProjetoGenesys.App.model
{
    class Conexao
    {
        public class SqlServer
        {
            static string sqlServer = (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_genesys;Integrated Security=True;Pooling=False");
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
