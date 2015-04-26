using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class AFController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MadeMeWrong()
        {
            throw new Exception("test OK");
            return View();
        }
        [HandleError(Master = "", ExceptionType = typeof(ArgumentException), View = "Error.Argument")]
        public ActionResult MadeMeWrong2(string type = "")
        {
            if (type == "1")
            {
                throw new ArgumentException("OK");
            }
            else
            {
                throw new Exception("test OK");
            }
            return View();
        }
    }
}