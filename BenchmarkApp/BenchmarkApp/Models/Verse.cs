using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Benchmark.Models
{
    public class Verse
    {
        [Required]
        [DisplayName("Testament")]
        [StringLength(255, MinimumLength =1, ErrorMessage ="Testament must contain between 1 and 255 characters.")]
        [DefaultValue("")]
        public string Testament { get; set; }
        [Required]
        [DisplayName("Book")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Book must contain between 1 and 255 characters.")]
        [DefaultValue("")]
        public string Book { get; set; }
        [Required]
        [DisplayName("Chapter Number")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Chapter Number must contain between 1 and 10 characters.")]
        [DefaultValue("")]
        public string ChapterNumber { get; set; }
        [Required]
        [DisplayName("Verse Number")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Verse Number must contain between 1 and 10 characters.")]
        [DefaultValue("")]
        public string VerseNumber { get; set; }
        [Required]
        [DisplayName("Verse Text")]
        [StringLength(255, MinimumLength = 1, ErrorMessage = "Verse Text must contain between 1 and 255 characters.")]
        [DefaultValue("")]
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