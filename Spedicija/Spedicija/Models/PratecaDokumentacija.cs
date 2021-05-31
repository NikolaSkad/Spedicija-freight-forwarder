using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Spedicija.Models
{
    public class PratecaDokumentacija
    {
        public int IdPratecaDokumentacija { get; set; }
        public Klijent Klijent { get; set; }
        public bool CMR { get; set; }
        public bool UverenjeOPoreklu { get; set; }

    }
}