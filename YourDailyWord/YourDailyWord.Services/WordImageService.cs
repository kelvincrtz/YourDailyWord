using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using YourDailyWord.Data;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Services
{
    public class WordImageService : IWordImage
    {
        private readonly YourDailyWordDbContext _YourDailyWordDbContext;

        public WordImageService(YourDailyWordDbContext YourDailyWordDbContext)
        {
            _YourDailyWordDbContext = YourDailyWordDbContext;
        }

        public IEnumerable<WordGallery> GetAll()
        {
            return _YourDailyWordDbContext.WordGalleries.Include(wordImg => wordImg.Tags);
        }

        public WordGallery GetById(int id)
        {
            return GetAll().Where(wordImg => wordImg.Id == id).First();
        }

        public IEnumerable<WordGallery> GetByTag(string tag)
        {
            throw new NotImplementedException();
        }
    }
}
