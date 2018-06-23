using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewGen5.Models;

namespace NewGen5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult AddVendor()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DisplayVendor()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DisplayEmployee()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DisplayUser()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Backup()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Restore()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Order()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Expenses()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DisplayQuotes()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult QuoteType()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DisplayServiceProvider()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult ServiceProviderTypes()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult ExchangeRate()
        {
            ViewData["Message"] = "Your application description page.";

            return View(); 
        }
        public IActionResult UserReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult VendorReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult ExpenseReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult OrderReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult DepartmentBudgetReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult ServiceProviderReport()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Register()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }








        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
