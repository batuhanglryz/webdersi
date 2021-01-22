using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFinalodevi.Controllers
{
    public class OyunlarController : Controller
    {
        
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var oyunlar = session.Query<Models.oyunlar>().ToList();
                return View(oyunlar);
            }
        }
    }
}