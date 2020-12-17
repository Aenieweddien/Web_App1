using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_App1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        private Models.Shop1Model db = new Models.Shop1Model();
        public ActionResult Index()
        {
            var Items = db.comics;
            return View(Items);
        }
        public ActionResult Thiscomic(int Id_comic)
        {
            return View(db.comics.Where(p => p.Id_comic == Id_comic).Take(1));
        }
        public ActionResult AboutUs()
        {
            return View();
        }
    }
}