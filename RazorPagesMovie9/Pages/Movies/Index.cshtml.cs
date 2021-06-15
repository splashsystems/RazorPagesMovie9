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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie9.Data.RazorPagesMovie9Context _context;

        public IndexModel(RazorPagesMovie9.Data.RazorPagesMovie9Context context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
