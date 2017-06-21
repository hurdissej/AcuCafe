using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcuCafe.Controllers
{
    public class Angular2Controller : Controller
    {
        // GET: Angular2
        public ActionResult Index()
        {
            return View("~/clientapp/src/index.cshtml");
        }
    }
}