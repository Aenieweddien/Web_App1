﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_App1.Areas.Admin.Controllers
{
    //ogranichit Admin+ manager
   // [Authorize(Roles = "Admin,Manager")]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}