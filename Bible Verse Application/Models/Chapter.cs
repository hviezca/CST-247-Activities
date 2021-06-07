using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class Chapter
    {
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Book")]
        public int Book { get; set; }
        [Required]
        [DisplayName("Chapter Number")]
        [Range(1, 150)]
        public int ChapterNumber { get; set; }

        public Chapter(){}

        public Chapter(int id, int book, int chapterNumber)
        {
            Id = id;
            Book = book;
            ChapterNumber = chapterNumber;
        }
    }
}