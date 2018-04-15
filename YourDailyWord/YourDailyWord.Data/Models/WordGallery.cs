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
        public string Description { get; set; }
        public string BibleVerse { get; set; }

        public virtual IEnumerable<WordTag> Tags { get; set; }

    }
}
