﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M.Admin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Default()
        {
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

    }
}
