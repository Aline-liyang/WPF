using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorPages.Data;
using WebApplicationRazorPages.Modeles;

namespace WebApplicationRazorPages.Pages.Employes
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationRazorPages.Data.WebApplicationRazorPagesContext _context;

        public IndexModel(WebApplicationRazorPages.Data.WebApplicationRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Employe> Employe { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Employe != null)
            {
                Employe = await _context.Employe.ToListAsync();
            }
        }
    }
}
