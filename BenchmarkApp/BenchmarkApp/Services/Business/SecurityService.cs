using Benchmark.Models;
using Benchmark.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Benchmark.Services.Business
{
    public class SecurityService
    {
        [Dependency]
        public VerseDAO verseDAO { get; set; }

        public bool createVerse(Verse verse)
        {
            return verseDAO.createVerse(verse);
        }

        public List<Verse> getVerse(Verse verse)
        {
            return verseDAO.GetVerse(verse);
        }
    }
}