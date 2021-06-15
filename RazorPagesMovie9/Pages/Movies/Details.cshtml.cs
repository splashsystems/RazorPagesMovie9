using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie9.Data;
using RazorPagesMovie9.Models;

namespace RazorPagesMovie9.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie9.Data.RazorPagesMovie9Context _context;

        public DetailsModel(RazorPagesMovie9.Data.RazorPagesMovie9Context context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
