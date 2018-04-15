using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourDailyWord.Models;

namespace YourDailyWord.Controllers
{
    public class WordController : Controller
    {
        public IActionResult Index()
        {
            var model = new WordIndexModel()
            {

            };
            return View(model);
        }
    }
}