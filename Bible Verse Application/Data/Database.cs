using System.Data.SqlClient;


namespace BibleVerseApp.Data
{
    public class Database
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BibleVerseApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public SqlConnection DbConnection()
        {
            // Get connection
            SqlConnection connection = new SqlConnection(connectionString);

            if (connection != null)
            {
                // Return connection
                return connection;
            }
            else
            {
                // Return null if connection failed
                return null;
            }
        }
    }
}