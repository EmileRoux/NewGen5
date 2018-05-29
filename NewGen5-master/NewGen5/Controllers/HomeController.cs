﻿using System;
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
        public IActionResult BackupScreen()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Restore()
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
