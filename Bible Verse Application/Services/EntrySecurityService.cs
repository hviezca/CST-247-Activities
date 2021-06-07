using BibleVerseApp.Data;
using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BibleVerseApp.Services
{
    public class EntrySecurityService
    {
        Database database = new Database();
        EntrySecurityDAO DAO = new EntrySecurityDAO();

        public bool CreateEntry(FormCollection collection)
        {
            var dbConnect = database.DbConnection();
            return DAO.CreateEntry(collection, dbConnect);
        }
    }
}