using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class Racun
    {
        public int Id { get; set; }
        public JCI JCI { get; set; }
        public double IznosRacuna { get; set; }
        public bool Storniran { get; set; }
    }
}