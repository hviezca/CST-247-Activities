using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Data
{
    public class EntrySecurityDAO
    {
        public bool CreateEntry(FormCollection collection, SqlConnection dbConnection)
        {
            // Will return true or false if registered.
            bool success = false;
            // Prepared statement
            SqlCommand command;
            int affectedRow = 0;

            using (var atomicTransaction = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                try
                {
                    string sqlStatementBook = "Insert into dbo.Book (Testament, BookName) " +
                                  "VALUES (@Testament, @BookName); SELECT SCOPE_IDENTITY()";

                    // Prepared statement
                    command = new SqlCommand(sqlStatementBook, dbConnection);
                    command.Parameters.Add("@Testament", System.Data.SqlDbType.NVarChar, 20).Value = collection[1];
                    command.Parameters.Add("@BookName", System.Data.SqlDbType.NVarChar, 20).Value = collection[2];

                    dbConnection.Open();

                    // Executes query and returns the row number of the affected row.
                    affectedRow = Convert.ToInt32(command.ExecuteScalar());

                    if (affectedRow > 0)
                    {
                        dbConnection.Close();
                    }
                    else
                    {
                        success = false;                       
                    }

                    string sqlStatementChapter = "Insert into dbo.Chapter (Book, ChapterNumber) " +
                                      "VALUES (@Book, @ChapterNumber); SELECT SCOPE_IDENTITY()";

                    // Prepared statement
                    command = new SqlCommand(sqlStatementChapter, dbConnection);
                    command.Parameters.Add("@Book", System.Data.SqlDbType.Int).Value = affectedRow;
                    command.Parameters.Add("@ChapterNumber", System.Data.SqlDbType.Int).Value = collection[3];

                    dbConnection.Open();

                    // Executes query and returns the row number of the affected row.
                    affectedRow = Convert.ToInt32(command.ExecuteScalar());

                    if (affectedRow > 0)
                    {
                        dbConnection.Close();
                    }

                    string sqlStatementVerse = "Insert into dbo.Verse (Chapter, VerseNumber, VerseText) " +
                                      "VALUES (@Chapter, @VerseNumber, @VerseText); SELECT SCOPE_IDENTITY()";

                    // Prepared statement
                    command = new SqlCommand(sqlStatementVerse, dbConnection);
                    command.Parameters.Add("@Chapter", System.Data.SqlDbType.Int).Value = affectedRow;
                    command.Parameters.Add("@VerseNumber", System.Data.SqlDbType.Int).Value = collection[4];
                    command.Parameters.Add("@VerseText", System.Data.SqlDbType.NVarChar, 100).Value = collection[5];

                    dbConnection.Open();

                    // Executes query and returns the row number of the affected row.
                    affectedRow = Convert.ToInt32(command.ExecuteScalar());

                    if (affectedRow > 0)
                    {
                        dbConnection.Close();
                    }

                    atomicTransaction.Complete();
                    success = true;                    
                }
                catch (Exception e)
                {
                    atomicTransaction.Dispose();
                    Console.WriteLine(e.Message);
                }

                return success;
            }
        }
    }
}