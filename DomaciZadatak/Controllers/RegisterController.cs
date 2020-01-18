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
    public class RegisterController : Controller
    {
        KorisniciDataContext kDC = new KorisniciDataContext();
        private IKorisnikRepository korisnikRepository;
        // GET: Register
        public RegisterController()
        {
            korisnikRepository = new KorisnikSqlRepository();
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Dodaj(KorisnikBO korisnik)
        {
            korisnikRepository.Dodaj(korisnik);
            return RedirectToAction("Index");
        }
    }
}