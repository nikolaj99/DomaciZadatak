using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomaciZadatak.Models
{
    public class KorisnikBO
    {
        public int JMBG { get; set; }

        public string Ime { get; set; }

        public string Prezime { get; set; }

        public int DatumRodj { get; set; }

        public string Email { get; set; }

        public string Lozinka { get; set; }

    }
}