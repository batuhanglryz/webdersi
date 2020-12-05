using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace vizeodevv1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Formula()
        {
            ViewBag.message = "formula sayfası";
            return View();
        }
        public ActionResult Kazananlar()
        {
            ViewBag.message = "SON 5 YARIŞ KAZANANLAR";
            return View();
        }
    }

}