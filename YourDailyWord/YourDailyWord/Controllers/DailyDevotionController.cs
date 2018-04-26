using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourDailyWord.Data;
using YourDailyWord.Models;

namespace YourDailyWord.Controllers
{
    public class DailyDevotionController : Controller
    {
        private readonly IDailyDevotion _dailyDevotion;

        public DailyDevotionController(IDailyDevotion dailyDevotion)
        {
            _dailyDevotion = dailyDevotion;
        }

        public IActionResult Index()
        {
            var _model = _dailyDevotion.GetById(1);

            var model = new DailyDevotionIndexModel()
            {
                Title = _model.Title,
                Author = _model.Author,
                Date = _model.Date,
                Description1 = _model.Description1,
                Description2 = _model.Description2,
                Description3 = _model.Description3,
                Description4 = _model.Description4,
                Verse = _model.Verse,
                VerseTitle = _model.VerseTitle,
                ImageURL = _model.ImageURL
            };

            return View(model);
        }
    }
}