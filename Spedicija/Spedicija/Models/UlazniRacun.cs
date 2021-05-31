using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class UlazniRacun
    {
        public int IdUlazniRacun { get; set; }
        public string NazivUsluge { get; set; }
        public float CenaUsluge { get; set; }
    }
}