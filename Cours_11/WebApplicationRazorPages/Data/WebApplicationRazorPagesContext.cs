using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorPages.Modeles;

namespace WebApplicationRazorPages.Data
{
    public class WebApplicationRazorPagesContext : DbContext
    {
        public WebApplicationRazorPagesContext (DbContextOptions<WebApplicationRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationRazorPages.Modeles.Employe> Employe { get; set; } = default!;

        public DbSet<WebApplicationRazorPages.Modeles.Client> Client { get; set; }
    }
}
