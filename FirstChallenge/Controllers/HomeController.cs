using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var comics = Models.ComicBookManager.GetComicBooks();

            return View(comics);
        }

        public ActionResult Details(int id)
        {
            var comics = Models.ComicBookManager.GetComicBooks();
            var comic = comics.FirstOrDefault(p => p.ComicBookId == id);

            return View(comic);
        }

    }
}