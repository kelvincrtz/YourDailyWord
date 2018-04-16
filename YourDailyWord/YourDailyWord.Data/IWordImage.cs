using System;
using System.Collections.Generic;
using System.Text;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Data
{
    public interface IWordImage
    {
        IEnumerable<WordGallery> GetAll();
        IEnumerable<WordGallery> GetByTag(string tag);
        WordGallery GetById(int id);

    }
}
