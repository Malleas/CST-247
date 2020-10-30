using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Benchmark.Models
{
    public class Verse
    {
        public string Testament { get; set; }
        public string Book { get; set; }
        public string ChapterNumber { get; set; }
        public string VerseNumber { get; set; }
        public string VerseText { get; set; }

        public Verse(string testament, string book, string chapterNumber, string verseNumber, string verseText)
        {
            Testament = testament;
            Book = book;
            ChapterNumber = chapterNumber;
            VerseNumber = verseNumber;
            VerseText = verseText;
        }

        public Verse()
        {
        }
    }
}