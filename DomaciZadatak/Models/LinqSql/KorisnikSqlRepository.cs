using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DomaciZadatak.Models.Interfaces;

namespace DomaciZadatak.Models.LinqSql
{
    public class KorisnikSqlRepository : IKorisnikRepository
    {
        private KorisniciDataContext kDC = new KorisniciDataContext();
        public void Dodaj(KorisnikBO korisnik)
        {
            throw new NotImplementedException();
        }

        public KorisnikBO GetById(int korisnikid)
        {
            throw new NotImplementedException();
        }

        public List<KorisnikBO> ListAll()
        {
            List<KorisnikBO> korisniks = new List<KorisnikBO>();
            foreach (Korisnik k in kDC.Korisniks)
            {
                KorisnikBO korisnikBO = new KorisnikBO();
                korisnikBO.JMBG = k.JMBG;
                korisnikBO.Ime = k.Ime;
                korisnikBO.Prezime = k.Prezime;
                korisnikBO.Email = k.Email;
                korisnikBO.DatumRodj = k.DatumRodj;
                korisnikBO.Lozinka = k.Lozinka;
                korisniks.Add(korisnikBO);
            }
            
            return korisniks;
        }

        public void Obrisi(KorisnikBO korisnik)
        {
            throw new NotImplementedException();
        }

        public void Update(KorisnikBO korisnik)
        {
            throw new NotImplementedException();
        }
    }
}