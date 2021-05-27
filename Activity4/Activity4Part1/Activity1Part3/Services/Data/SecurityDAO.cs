using Activity1Part3.Models;
using System;
using System.Data.SqlClient;

namespace Activity1Part3.Services.Data
{
    public class SecurityDAO
    {
        // LocalDB connrction string
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Test;Integrated Security=True;
                                    Connect Timeout=30;
                                    Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public bool FindByUser(UserModel user)
        {
            // Returns true or false if user found in DB. Set to false by default. 
            bool success = false;

            string sqlStatment = "SELECT * FROM dbo.Users WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatment, connection);

                // Prepared statement. 
                command.Parameters.Add("@username", System.Data.SqlDbType.NVarChar, 50).Value = user.Username;
                command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 50).Value = user.Password;

                // Try/Catch block for exception catching.
                try
                {
                    // Open DB connection and execute SQL statement.
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Set success to true if match found in DB
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return success;
        }
    }
}