using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourDailyWord.Data;
using YourDailyWord.Data.Models;
using YourDailyWord.Models;

namespace YourDailyWord.Controllers
{
    public class WordController : Controller
    {
        private readonly IWordImage _IWordImage;

        public WordController(IWordImage IWordImage)
        {
            _IWordImage = IWordImage;
        }

        public IActionResult Index()
        {
            var model = new WordIndexModel()
            {
                WordGallery = _IWordImage.GetAll(),
                SearchQuery = ""
            };

            return View(model);
        }
    }
}