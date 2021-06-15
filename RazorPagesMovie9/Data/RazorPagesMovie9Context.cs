using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie9.Models;

namespace RazorPagesMovie9.Data
{
    public class RazorPagesMovie9Context : DbContext
    {
        public RazorPagesMovie9Context (DbContextOptions<RazorPagesMovie9Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie9.Models.Movie> Movie { get; set; }
    }
}
