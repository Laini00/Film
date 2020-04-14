using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Film_laini.Data;
using Film_laini.Models;
using Microsoft.AspNetCore.Authorization;

namespace Film_laini
{
    public class IndexModel : PageModel
    {
        private readonly Film_laini.Data.Film_lainiContext _context;

        public IndexModel(Film_laini.Data.Film_lainiContext context)
        {
            _context = context;
        }

        public IList<film> listafilm { get;set; }

        public async Task OnGetAsync()
        {
            listafilm = await _context.film.ToListAsync();
        }
    }
}
