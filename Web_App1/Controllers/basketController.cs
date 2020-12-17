using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_App1.Controllers
{
    public class basketController : Controller
    {
        // GET: basket
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult addto()
        {
            return View();
        }
    }
}