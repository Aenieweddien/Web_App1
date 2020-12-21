using System;
using System.Collections.Generic;
using Web_App1.Models.Data;
using Web_App1.Models.ViewModels.Pages;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Web_App1.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        //public int pageSize = 4;
        private Models.Shop1Model db = new Models.Shop1Model();
        public ActionResult Index()
        {
            List<PageVM> Items;
            using (DB db = new DB())
            {
                Items = db.Pages.ToArray().OrderBy(x => x.Id_comic).Select(x => new PageVM(x)).ToList();
            }
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

        public ActionResult Home()
        {
            return View();
        }
    }
}