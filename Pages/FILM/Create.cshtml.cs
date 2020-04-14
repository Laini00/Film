using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Film_laini.Data;
using Film_laini.Models;
using Microsoft.AspNetCore.Authorization;

namespace Film_laini
{
    public class CreateModel : PageModel
    {
        private readonly Film_laini.Data.Film_lainiContext _context;

        public CreateModel(Film_laini.Data.Film_lainiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public film film { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.film.Add(film);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
