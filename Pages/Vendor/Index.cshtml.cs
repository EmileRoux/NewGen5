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
    public class IndexModel : PageModel
    {
        private readonly NewGen5Razor.Models.NewGenContext _context;

        public IndexModel(NewGen5Razor.Models.NewGenContext context)
        {
            _context = context;
        }

        public IList<Vendors> Vendors { get;set; }

        public async Task OnGetAsync(string searchString)
        {
            var vendor = from m in _context.Vendors
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                vendor = vendor.Where(s => s.VendorName.Contains(searchString));
            }

            Vendors = await vendor.ToListAsync();
        }

        [BindProperty]
        public Vendors TheVendors { get; set; }

        public async Task<IActionResult> OnPostFirstAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vendors.Add(TheVendors);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }


        //public async Task<IActionResult> OnPostSecondAsync()
        //{
        //    _context.Attach(TheVendors).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!VendorsExists(TheVendors.VendorsID))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return RedirectToPage("./Index");
        //}

        //private bool VendorsExists(int id)
        //{
        //    return _context.Vendors.Any(e => e.VendorsID == id);
        //}

    }
}
