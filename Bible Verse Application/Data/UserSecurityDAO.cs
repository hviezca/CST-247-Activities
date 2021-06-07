using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Data
{    
    public class UserSecurityDAO
    {
        public bool FindByUsernameAndPassword(string username, string password, SqlConnection dbConnection)
        {
            string sqlStatement = "Select * from [dbo].[User] where UserName = @UserName AND Password = @Password";

            // Will return true or false if found
            bool success = false;

            SqlCommand command = new SqlCommand(sqlStatement, dbConnection);

            // Prepared statement
            command.Parameters.Add("@UserName", System.Data.SqlDbType.NVarChar, 20).Value = username;
            command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 20).Value = password;

            try
            {
                dbConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dbConnection.Close();
                    success = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Return if found
            return success;
        }

        internal bool RegisterUser(User user, SqlConnection dbConnection)
        {
            string sqlStatement = "Insert into [dbo].[User] (Username, Password, Email) " +
                                  "VALUES (@Username, @Password, @Email)";

            // Will return true or false if registered.
            bool success = false;

            // Prepared statement
            SqlCommand command = new SqlCommand(sqlStatement, dbConnection);            
            command.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 20).Value = user.UserName;
            command.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 20).Value = user.Password;
            command.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 50).Value = user.Email;

            try
            {
                dbConnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.RecordsAffected > 0)
                {
                    dbConnection.Close();
                    success = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Return registration result
            return success;
        }

    }
}