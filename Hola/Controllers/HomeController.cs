using Hola.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity.Migrations;

namespace Hola.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index(string lang, Counter c)
        {
            return View("Index", c);
        }

        [Authorize]
        public ActionResult QIndex(string lang, Counter c)
        {
            return View("QIndex", c);
        }

        [Authorize]
        public ActionResult Levels(string lang, Counter c)
        {
            return View("Levels", c);
        }

        [Authorize]
        public ActionResult QLevels(string lang, Counter c)
        {
            return View("QLevels", c);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult NextWord(Counter c)
        {
            using (ApplicationDbContext DB = new ApplicationDbContext())
            {
                User_Words newWord= new User_Words()
                {
                    ApplicationUserID = User.Identity.GetUserId(),
                    LanguageID = c.LanguageSelected,
                    Level = c.LevelSelected,
                    WordID = c.WordNum + 1,
                    LastVisited = DateTime.Now,
                    Mastery = 1
                };
                DB.User_Words.AddOrUpdate(newWord);
                DB.SaveChanges();
                c.WordNum = c.WordNum + 1;

                var wordsList = DB.Words.Where(w => w.LanguageID == c.LanguageSelected && w.Level == c.LevelSelected).Select(w => w.WordText).ToList();
                if (c.WordNum + 1 >= wordsList.Count)
                {
                    c.IsLevelDone = true;
                }
                if (c.WordNum >= wordsList.Count)
                {
                    c.WordNum = 0;
                    c.IsLevelDone = false;
                }
                return View("Index", c);
            }
        }

        [Authorize]
        public ActionResult NextQues(Counter c)
        {
            using (ApplicationDbContext DB = new ApplicationDbContext())
            {
                #region Legacy
                //User_Words user_Words = new User_Words()
                //{
                //    ApplicationUserID = User.Identity.GetUserId(),
                //    LanguageID = c.LanguageSelected,
                //    Level = c.LevelSelected,
                //    WordID = c.WordNum + 1,
                //    LastVisited = DateTime.Now,
                //    Mastery = 1
                //};
                //DB.User_Words.AddOrUpdate(user_Words);
                //DB.SaveChanges();
                #endregion

                c.WordNum = c.WordNum + 1;

                var QuesList = DB.Questions.Where(w => w.LanguageID == c.LanguageSelected && w.Level == c.LevelSelected).Select(w => w.QuestionText).ToList();
                if (c.WordNum + 1 >= QuesList.Count)
                {
                    c.IsLevelDone = true;
                }
                if (c.WordNum >= QuesList.Count)
                {
                    c.WordNum = 0;
                    c.IsLevelDone = false;
                }
                return View("QIndex", c);
            }
        }


        [Authorize]
        public ActionResult Languages()
        {
            return View();
        }
    }
}