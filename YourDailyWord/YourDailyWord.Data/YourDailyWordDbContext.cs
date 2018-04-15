using Microsoft.EntityFrameworkCore;
using System;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Data
{
    public class YourDailyWordDbContext : DbContext
    {
        public YourDailyWordDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<WordGallery> WordGalleries { get; set; }
        public DbSet<WordTag> WordTags { get; set; }
    }
}
