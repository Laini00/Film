using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Film_laini.Models;

namespace Film_laini.Data
{
    public class Film_lainiContext : DbContext
    {
        public Film_lainiContext (DbContextOptions<Film_lainiContext> options)
            : base(options)
        {
        }

        public DbSet<Film_laini.Models.film> film { get; set; }
    }
}
