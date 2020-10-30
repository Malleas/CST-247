using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Benchmark.Models
{
    public class VerseObject
    {
        public string JsonString { get; set; }

        public VerseObject(string jsonString)
        {
            JsonString = jsonString;
        }
    }
}