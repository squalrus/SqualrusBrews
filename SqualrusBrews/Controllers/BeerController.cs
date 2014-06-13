using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SqualrusBrews.Controllers
{
    public class BeerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}