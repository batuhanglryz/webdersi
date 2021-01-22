using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebFinalodevi.Controllers
{
    public class GenelController : Controller
    {
        
      

        public ActionResult Listele2()
        {
            using (var session = NhibernateHelper.OpenSession())
            {
                var oyunlar = session.Get<Models.oyunlar>(1);
                var knslf = session.Query<Models.konsol>().Where(x=> x.Id == 1).FirstOrDefault();
                var knslYeni = new Models.konsol() { marka = "sony", hafıza = "500"};
                
                var oyunlarim = new Models.oyunlar() { oyunisim = "sonic", fiyat="212" };
                oyunlar.konsol = knslYeni;

                
                oyunlar.oyunisim = "sonic";
                oyunlar.fiyat = "212";
                oyunlar.konsol = knslYeni;

                knslYeni.oyunlarim.Add(oyunlar);

                session.SaveOrUpdate(oyunlar);
                session.Flush();

                var konsol = session.Query<Models.konsol>().Where(x => x.marka == "sony").FirstOrDefault();
                oyunlar.konsol = konsol;


                //var t = konsol.oyunlarim;
               //linq query

               // knsl.marka = "sony";
                //knsl.oyunlar = "sonic";
                //var knslQ = session.Query<Models.konsol>().Where(x => x.hafıza == "500").ToList();
                //rollback 
                //commit

                //var knsl = new Models.knsl()
               // {
               //  marka = "sony",
                // hafiza = "500",
                
               // };

                var knsl = session.Query<Models.konsol>().FirstOrDefault(x => x.Id == 7);

                session.SaveOrUpdate(knsl);

                session.Delete(knsl);

            }


            return View();
        }

      
    }
}