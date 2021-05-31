using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class IzlazniRacun
    {
        public int IdIzlazniRacun { get; set; }
        public Klijent Klijent { get; set; }
        public bool PostupakKlijent { get; set; }
        public bool DugovanjeKlijent { get; set; }
        public string NazivCarinskiStav { get; set; }

    }
}