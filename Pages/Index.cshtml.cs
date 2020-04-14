using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Film_laini.Pages
{
    public class IndexModel : PageModel
    {
        public string Newss;
        public int A;
        Random random = new Random();
        private string[] news = { "Consultare il sito Web del cinema desiderato per verificare la presenza del film", "Uscito il nuovo film degli Avengers", "Apertura delle nuove sale per i film 3D", "Nuova offerta per il mese di Agosto: PopCorn con Bibita e M&M a soli 7 euro !! " };
        
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            A = random.Next(4);
            Newss = news[A];
        }
    }
}
