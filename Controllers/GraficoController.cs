﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edu_Visual_Web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult PerdaMes()
        {
            return View();
        }
        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
        [Authorize]
        public ActionResult SobreGrafico()
        {
            return View();
        }
    }
}