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
    public class DeleteModel : PageModel
    {
        private readonly Film_laini.Data.Film_lainiContext _context;

        public DeleteModel(Film_laini.Data.Film_lainiContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            film = await _context.film.FindAsync(id);

            if (film != null)
            {
                _context.film.Remove(film);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
