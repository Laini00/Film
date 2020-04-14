using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Film_laini.Data;
using Film_laini.Models;
using Microsoft.AspNetCore.Authorization;

namespace Film_laini
{
    public class EditModel : PageModel
    {
        private readonly Film_laini.Data.Film_lainiContext _context;

        public EditModel(Film_laini.Data.Film_lainiContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!filmExists(film.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool filmExists(string id)
        {
            return _context.film.Any(e => e.ID == id);
        }
    }
}
