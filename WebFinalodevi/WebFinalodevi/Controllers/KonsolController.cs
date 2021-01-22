using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFinalodevi.Controllers
{
    public class KonsolController : Controller
    {
        
        public ActionResult Index()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var konsollar = session.Query<Models.konsol>().Fetch(x => x.oyunlarim).ToList();
                return View(konsollar);
            }
        }

        public ActionResult Yeni()
        {
            return View();
        }

        public ActionResult Edit(int id)
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var konsollar = session.Query<Models.konsol>().FirstOrDefault(x => x.Id == id);
                return View(konsollar);
            }
        }

    }
}