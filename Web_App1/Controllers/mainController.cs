﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_App1.Controllers
{
    public class mainController : Controller
    {
        // GET: main
        public ActionResult Index()
        {
            return View("~/Views/main/mainpage.cshtml");
        }
    }
}