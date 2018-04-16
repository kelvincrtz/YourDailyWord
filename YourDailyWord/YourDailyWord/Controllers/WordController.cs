using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourDailyWord.Data.Models;
using YourDailyWord.Models;

namespace YourDailyWord.Controllers
{
    public class WordController : Controller
    {
        public IActionResult Index()
        {
            var tag1 = new WordTag() {
                Id = 1,
                Description = "Forgiveness"
            };
            var tag2 = new WordTag()
            {
                Id = 2,
                Description = "Love"
            };

            var tagList1 = new List<WordTag>();
            var tagList2 = new List<WordTag>();

            tagList1.Add(tag1);
            tagList2.AddRange(new List<WordTag>() {tag1, tag2});


            var wordGalleryList = new List<WordGallery>()
            {
                new WordGallery()
                {
                    Id = 1,
                    Title = "Title 1",
                    Url = "",
                    BibleVerse = "Bible Verse 1",
                    Description = "Description 1",
                    Created = DateTime.Now,
                    Tags = tagList1,
                },
                new WordGallery()
                {
                    Id = 2,
                    Title = "Title 2",
                    Url = "",
                    BibleVerse = "Bible Verse 2",
                    Description = "Description 2",
                    Created = DateTime.Now,
                    Tags = tagList2,
                },
                new WordGallery()
                {
                    Id = 3,
                    Title = "Title 3",
                    Url = "",
                    BibleVerse = "Bible Verse 3",
                    Description = "Description 3",
                    Created = DateTime.Now,
                    Tags = tagList1,
                }
            };

            var model = new WordIndexModel()
            {
                WordGallery = wordGalleryList,
                SearchQuery = ""
            };

            return View(model);
        }
    }
}