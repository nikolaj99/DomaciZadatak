using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DomaciZadatak.Models
{
    public class UplataBO
    {
        public int IDUsluge { get; set; }
        public int Cene { get; set; }
        public DateTime Datum { get; set; }
        public int JMBG { get; set; }
        public int AktivnostID { get; set; }

    }
}