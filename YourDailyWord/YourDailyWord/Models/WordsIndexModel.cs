using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourDailyWord.Models
{
    public class WordsIndexModel
    {
        public IEnumerable<WordGallery> WordGallery {get; set;}
        public String search { get; set; }

    }
}
