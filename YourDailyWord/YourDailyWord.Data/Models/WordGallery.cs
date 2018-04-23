using System;
using System.Collections.Generic;
using System.Text;

namespace YourDailyWord.Data.Models
{
    public class WordGallery
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string IndexUrl { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Verse1 { get; set; }
        public string Verse2 { get; set; }
        public string Verse3 { get; set; }
        public DateTime Created { get; set; }

        public virtual IEnumerable<WordTag> Tags { get; set; }

    }
}
