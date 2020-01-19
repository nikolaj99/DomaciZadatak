using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DomaciZadatak.Models;
using DomaciZadatak.Models.Interfaces;
using DomaciZadatak.Models.LinqSql;

namespace DomaciZadatak.Controllers
{
    public class UplataController : Controller
    {
        KorisniciDataContext kDC = new KorisniciDataContext();
        // GET: Uplata
        public ActionResult Index()
        {
            List<Aktivnost> aktivnosti = new List<Aktivnost>();
            foreach(Aktivnost a in kDC.Aktivnosts)
            {
                aktivnosti.Add(a);
            }
            ViewBag.Usluge = aktivnosti;
            return View();
        }

        public ActionResult GetCena(int id)
        {
            string cena;
            Aktivnost akt = new Aktivnost();
            akt = kDC.Aktivnosts.First(x => x.AktivnostID == id);
            cena = Convert.ToString(akt.Cena);
            return Json(cena, JsonRequestBehavior.AllowGet);

        }
    }
}