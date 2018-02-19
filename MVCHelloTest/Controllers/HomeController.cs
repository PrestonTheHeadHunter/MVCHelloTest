using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelloTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "I've changed, it's all about the team dynamic";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact my assistant";

            return View();
        }
    }
}