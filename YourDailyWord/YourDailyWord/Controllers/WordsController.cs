using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourDailyWord.Models;

namespace YourDailyWord.Controllers
{
    public class WordsController : Controller
    {
        public IActionResult Index()
        {
            var model = new WordsIndexModel()
            {

            };
            return View(model);
        }
    }
}