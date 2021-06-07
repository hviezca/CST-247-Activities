using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class User
    {
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }
        
        [Required]
        [DisplayName ("User Name")]
        [StringLength(20, MinimumLength = 4)]
        public string UserName { get; set; }

        [Required]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }


        public User(){}

        public User(int id, string userName, string password, string email)
        {
            Id = id;
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}