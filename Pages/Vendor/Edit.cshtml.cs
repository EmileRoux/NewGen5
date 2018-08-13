using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewGen5Razor.Models;

namespace NewGen5Razor.Pages.Vendor
{
    public class EditModel : PageModel
    {
        private readonly NewGen5Razor.Models.NewGenContext _context;

        public EditModel(NewGen5Razor.Models.NewGenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vendors Vendors { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vendors = await _context.Vendors.FirstOrDefaultAsync(m => m.VendorsID == id);

            if (Vendors == null)
            {
                return NotFound();
            }
            return Page();
          
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }

            _context.Attach(Vendors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorsExists(Vendors.VendorsID))
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

        private bool VendorsExists(int id)
        {
            return _context.Vendors.Any(e => e.VendorsID == id);
        }
    }
}
