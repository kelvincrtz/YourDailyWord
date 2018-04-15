using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Models
{
    public class WordIndexModel
    {
        public IEnumerable<WordGallery> WordGallery {get; set;}
        public String Search { get; set; }

    }
}
