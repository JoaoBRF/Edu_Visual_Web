﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Edu_Visual_Web.Controllers
{
    public class RelatorioController : Controller
    {
        [Authorize]
        public ActionResult PosicaoEstoque()
        {
            return View();
        }
        [Authorize]
        public ActionResult Ressuprimento()
        {
            return View();
        }
        [Authorize]
        public ActionResult SobreRelatorio()
        {
            return View();
        }
    }
}