using System;
using System.Collections.Generic;
using System.Text;
using YourDailyWord.Data.Models;

namespace YourDailyWord.Data
{
    public interface IDailyDevotion
    {
        IEnumerable<DailyDevotionInfo> GetAll();
        DailyDevotionInfo GetById(int id);
    }
}
