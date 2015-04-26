using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : Controller
    {
        // GET: AR
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult view1()
        {
            return View("view22");
        }

        public ActionResult view2()
        {
            return PartialView();
        }

        public ActionResult view3()
        {
            return Content("test");
        }
        public string Testcontent()
        {
            return "test content view. ";
        }
    }
}