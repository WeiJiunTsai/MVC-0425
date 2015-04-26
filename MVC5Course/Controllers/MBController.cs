using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class MBController : BaseController
    {
        // GET: MB
        public ActionResult Index()
        {
            var product = db.Product.Find(1);
            return View(product);
        }

        public ActionResult viewdata1()
        {
            ViewData["Message1"] = "Test1";
            ViewBag.Message2 = "Bag1";
            TempData["Messag3"] = "Test2";
            Session["Message4"] = "test3";
            return RedirectToAction("viewdata2");
        }
        public ActionResult viewdata2()
        {
            ViewData["ViewData"] = "Test ViewData";
            ViewBag.Message1 = ViewData["Message1"];
            ViewBag.Message2 = ViewBag.Message2;
            ViewBag.Message3 = TempData["Messag3"];
            ViewBag.Message4 = Session["Message4"];
            ViewBag.ViewBag = "Test ViewBag";
            return View();
        }
    }
}