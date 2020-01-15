using DomaciZadatak.Models;
using DomaciZadatak.Models.Interfaces;
using DomaciZadatak.Models.LinqSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DomaciZadatak.Controllers
{
    public class LoginController : Controller
    {
        KorisniciDataContext kDC = new KorisniciDataContext();
        private IKorisnikRepository korisnikRepository;
        // GET: Korisnik

        public LoginController()
        {
            korisnikRepository = new KorisnikSqlRepository();
        }
       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Odobri(KorisnikBO korisnikModel)
        {

            var korisnikPodaci = kDC.Korisniks.Where(x => x.Email == korisnikModel.Email && x.Lozinka == korisnikModel.Lozinka).FirstOrDefault();
            if (korisnikPodaci == null)
            {
                return View("Index", korisnikModel);
            }
            else
            {
                Session["Email"] = korisnikPodaci.Email;

                return RedirectToAction("Index", "Home");

            }
        }
        public ActionResult Izloguj()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }
    }
}