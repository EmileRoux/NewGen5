using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewGen5Razor.Models;

namespace NewGen5Razor.Pages.Vendor
{
    public class DetailsModel : PageModel
    {
        private readonly NewGen5Razor.Models.NewGenContext _context;

        public DetailsModel(NewGen5Razor.Models.NewGenContext context)
        {
            _context = context;
        }

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
    }
}
