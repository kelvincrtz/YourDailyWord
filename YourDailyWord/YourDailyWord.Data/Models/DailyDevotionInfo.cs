using System;
using System.Collections.Generic;
using System.Text;

namespace YourDailyWord.Data.Models
{
    public class DailyDevotionInfo
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Verse { get; set; }
        public string VerseTitle { get; set; }
    }
}
