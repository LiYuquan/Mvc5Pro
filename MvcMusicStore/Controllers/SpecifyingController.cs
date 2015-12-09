using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class SpecifyingController : Controller
    {
        // GET: Specifying
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC5!";
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC5!";
            return View("NoIndex.cshtml");
        }
        public ActionResult Index3()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC5!";
            return View("~/Views/Home/About.cshtml");
        }
        public ActionResult Message()
        {
            ViewBag.Message = "我是部分视图，哈哈哈";
            return PartialView();
        }
        public ActionResult PartialViewDemo()
        {
            return View();
        }
    }
}