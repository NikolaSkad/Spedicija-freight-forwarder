using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class Klijent
    {
        public int idKlijent { get; set; }
        public string nazivKlijent { get; set; }
        public string sedisteKlijent { get; set; }
        public string matBroj { get; set; }
    }
}