using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DomaciZadatak.Models
{
    public class KorisnikBO
    {
        [Display(Name ="JMBG : ")]
        public int JMBG { get; set; }
        [Display(Name = "Ime : ")]
        public string Ime { get; set; }
        [Display(Name = "Prezime : ")]
        public string Prezime { get; set; }
        [Display(Name = "Datum rodjenja : ")]
        public int DatumRodj { get; set; }
        [Display(Name = "E-mail : ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lozinka je potrebna")]
        [Display(Name = "Lozinka : ")]
        public string Lozinka { get; set; }

    }
}