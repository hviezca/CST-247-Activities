using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class Book
    {
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Testament")]
        [Range(0, 1)]
        public int Testament { get; set; }
        [Required]
        [DisplayName("Book Name")]
        public string BookName { get; set; }

        public Book() { }

        public Book(int id, int testament, string bookName)
        {
            Id = id;
            Testament = testament;
            BookName = bookName;
        }        
    }
}