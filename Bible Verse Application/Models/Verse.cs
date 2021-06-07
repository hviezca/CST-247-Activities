using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BibleVerseApp.Models
{
    public class Verse
    {
        [Required]
        [DisplayName("Id")]
        public int Id { get; set; }
        [Required]
        [DisplayName("Chapter")]
        public int Chapter { get; set; }
        [Required]
        [DisplayName("Verse Number")]
        [Range(1, 176)]
        public int VerseNumber { get; set; }
        [Required]
        [DisplayName("Verse Text")]
        public string VerseText { get; set; }

        public Verse(){}

        public Verse(int id, int chapter, int verseNumber, string verseText)
        {
            Id = id;
            Chapter = chapter;
            VerseNumber = verseNumber;
            VerseText = verseText;
        }
    }
}