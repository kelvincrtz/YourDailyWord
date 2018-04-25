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
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Verse1 { get; set; }
        public string Verse2 { get; set; }
        public string Verse3 { get; set; }
        public DateTime Created { get; set; }

        public List<string> Tags { get; set; }
    }
}
