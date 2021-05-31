using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class JCI
    {
        public int IdJCI { get; set; }
        public Roba Roba { get; set; }
        public Klijent Klijent { get; set; }
        public bool Plombirano { get; set; }
    }
}