using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Models
{
    public class WordDetailModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public string BibleVerse { get; set; }
        public DateTime Created { get; set; }

        public List Tags { get; set; }
    }
}
