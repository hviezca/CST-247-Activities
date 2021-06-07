using BibleVerseApp.Data;
using BibleVerseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Services
{
    public class UserSecurityService
    {
        Database database = new Database();
        UserSecurityDAO DAO = new UserSecurityDAO();
        public bool Login(User user)
        {            
            var dbConnect = database.DbConnection();
            return DAO.FindByUsernameAndPassword(user.UserName, user.Password, dbConnect);
        }

        public bool Register(User user)
        {
            var dbConnect = database.DbConnection();
            return DAO.RegisterUser(user, dbConnect);

        }
    }
}