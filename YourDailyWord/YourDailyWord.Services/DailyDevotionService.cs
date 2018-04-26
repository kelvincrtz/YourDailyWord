using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using YourDailyWord.Data;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Services
{
    public class DailyDevotionService : IDailyDevotion
    {
        private readonly YourDailyWordDbContext _ctx;

        public DailyDevotionService(YourDailyWordDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<DailyDevotionInfo> GetAll()
        {
            return _ctx.DailyDevotionInfos;
        }

        public DailyDevotionInfo GetById(int id)
        {
            return GetAll().Where(word => word.Id == id).First();
        }
    }
}
