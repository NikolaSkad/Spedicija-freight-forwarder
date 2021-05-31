using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class Roba
    {
        public int IdRoba { get; set; }
        public string Naziv { get; set; }
        public double Cena { get; set; }
        public CarniskaTarifa CarisnkaTarifa { get; set; }

    }
}