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
    public class DeleteModel : PageModel
    {
        private readonly WebApplicationRazorPages.Data.WebApplicationRazorPagesContext _context;

        public DeleteModel(WebApplicationRazorPages.Data.WebApplicationRazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Employe Employe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employe == null)
            {
                return NotFound();
            }

            var employe = await _context.Employe.FirstOrDefaultAsync(m => m.EmployeID == id);

            if (employe == null)
            {
                return NotFound();
            }
            else 
            {
                Employe = employe;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Employe == null)
            {
                return NotFound();
            }
            var employe = await _context.Employe.FindAsync(id);

            if (employe != null)
            {
                Employe = employe;
                _context.Employe.Remove(Employe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
