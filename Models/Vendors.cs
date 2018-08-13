using System;
using System.ComponentModel.DataAnnotations;

namespace NewGen5Razor.Models
{
    public class Vendors
    {
        public int VendorsID { get; set; }

        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }

        [Display(Name = "Physical Address")]
        public string PhysicalAddress { get; set; }

        [Display(Name = "Postal Address")]
        public string PostalAddress { get; set; }

        [Display(Name = "VAT Number")]
        public string VendorVATNumber { get; set; }

        [Display(Name = "Account Number")]
        public string AccountNumber { get; set; }

        [Display(Name = "Branch Code")]
        public string AccountBranch { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        [Display(Name = "Preference")]
        public int PreferencedID { get; set; }

        [Display(Name = "Vendor Type")]
        public int VendorTypeID { get; set; }

    }
}
