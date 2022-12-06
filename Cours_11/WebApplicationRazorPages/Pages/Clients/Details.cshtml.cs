using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorPages.Data;
using WebApplicationRazorPages.Modeles;

namespace WebApplicationRazorPages.Pages.Clients
{
    public class DetailsModel : PageModel
    {
        private readonly WebApplicationRazorPages.Data.WebApplicationRazorPagesContext _context;

        public DetailsModel(WebApplicationRazorPages.Data.WebApplicationRazorPagesContext context)
        {
            _context = context;
        }

      public Client Client { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null || _context.Client == null)
            {
                return NotFound();
            }

            var client = await _context.Client.FirstOrDefaultAsync(m => m.ClientID == id);
            if (client == null)
            {
                return NotFound();
            }
            else 
            {
                Client = client;
            }
            return Page();
        }
    }
}
