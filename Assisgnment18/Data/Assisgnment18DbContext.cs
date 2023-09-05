using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assisgnment18.Models;

namespace Assisgnment18.Data
{
    public class Assisgnment18DbContext : DbContext
    {
        public Assisgnment18DbContext (DbContextOptions<Assisgnment18DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assisgnment18.Models.Movie> Movie { get; set; } = default!;
    }
}
