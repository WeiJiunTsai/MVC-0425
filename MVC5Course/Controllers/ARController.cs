using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult File1()
        {
            byte[] content= System.IO.File.ReadAllBytes(Server.MapPath("~/Content/pic1.png"));
            return File(content,"image/png");
        }

        public ActionResult File2()
        {
            return File(Server.MapPath("~/Content/pic1.png"),"image/png");
        }

        public ActionResult File3(string url)
        {
            var wc = new WebClient();
            var content = wc.DownloadData(url);

            return File(content,"image/png");
        }
        public ActionResult file4()
        {
            return File(Server.MapPath("~/Content/file4.htm"),"text/plain");
        }
        public ActionResult File5()
        {
            byte[] content = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/pic1.png"));
            return File(content, "image/png","pic5.png");
        }
    }
}