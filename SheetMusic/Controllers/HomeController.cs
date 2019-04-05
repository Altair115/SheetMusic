using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SheetMusic.Models;

namespace SheetMusic.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //[HttpPost]
        public ActionResult Index(string searchParams)
        {
            var music = from m in db.Pieces select m;

            if (!String.IsNullOrEmpty(searchParams))
            {
                music = music.Where(m => m.PieceName.Contains(searchParams));
            }

            return View(music.ToList());
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
    }
}