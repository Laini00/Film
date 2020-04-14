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
    public class DetailsModel : PageModel
    {
        private readonly Film_laini.Data.Film_lainiContext _context;

        public DetailsModel(Film_laini.Data.Film_lainiContext context)
        {
            _context = context;
        }

        public film film { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            film = await _context.film.FirstOrDefaultAsync(m => m.ID == id);

            if (film == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
