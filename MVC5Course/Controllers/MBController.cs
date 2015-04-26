using MVC5Course.Models;
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

        public ActionResult Simple1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Simple1(string username, string password)
        {
            return Content("Simple1 = Username:" + username + "," + "PASS:" + password);
        }

        public ActionResult Simple2()
        {
            return View("Simple1");
        }
        [HttpPost]
        public ActionResult Simple2(FormCollection form)
        {
            return Content("Simple2 = Username:" + form["username"] + "," + "PASS:" + form["password"]);
        }

        public ActionResult Complex1()
        {
            return View("Simple1");
        }
        [HttpPost]
        public ActionResult Complex1(SimpleViewModel item)
        {
            return Content("complex1 = USER: " + item.UserName +", Pass: "+ item.PassWord);
        }

        public ActionResult Complex2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complex2(SimpleViewModel item1,SimpleViewModel item2)
        {
            return Content("complex2 = USER1: " + item1.UserName +", Pass: "+ item1.PassWord +"; User2:" + item2.UserName+",Pass:"+item2.PassWord);
        }

        public ActionResult Complex3()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Complex3([Bind(Prefix = "item1")]SimpleViewModel item)
        {
            return Content("complex3 = USER: " + item.UserName + ", Pass: " + item.PassWord);
        }

        public ActionResult Complex4()
        {
            var data = from a in db.Client
                       select new SimpleViewModel
                       {
                           UserName = a.FirstName,
                           PassWord = a.LastName,
                           age = 18
                       };
            return View(data.Take(10));
        }
        [HttpPost]
        public ActionResult Complex4(IList<SimpleViewModel> item)
        {
            return Content("");
        }

        
    }
}