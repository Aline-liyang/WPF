using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplicationRazorPages.Data;
using WebApplicationRazorPages.Modeles;

namespace WebApplicationRazorPages.Pages.Employes
{
    public class EditModel : PageModel
    {
        private readonly WebApplicationRazorPages.Data.WebApplicationRazorPagesContext _context;

        public EditModel(WebApplicationRazorPages.Data.WebApplicationRazorPagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Employe Employe { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employe == null)
            {
                return NotFound();
            }

            var employe =  await _context.Employe.FirstOrDefaultAsync(m => m.EmployeID == id);
            if (employe == null)
            {
                return NotFound();
            }
            Employe = employe;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Employe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeExists(Employe.EmployeID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EmployeExists(int id)
        {
          return _context.Employe.Any(e => e.EmployeID == id);
        }
    }
}
