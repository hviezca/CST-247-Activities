

namespace BibleVerseApp.Models
{
    public class BibleVerse
    {
        public Book Book { get; set; }
        public Chapter Chapter { get; set; }
        public Verse Verse { get; set; }

        public BibleVerse()
        {
        }

        public BibleVerse(Book book, Chapter chapter, Verse verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }
    }
}