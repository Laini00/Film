using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Film_laini.Models
{
    public class film
    {
        public string ID { get; set; }
         public string Titolo { get; set; }
        public string Trama { get; set; }
        public string AnnoDiUscita { get; set; }
        public string Regista { get; set; }
        public string Premi { get; set; }
    }
}
