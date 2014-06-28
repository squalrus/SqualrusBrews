using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;

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