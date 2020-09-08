using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Attendance.Models;
using Attendance.Data;

namespace Attendance.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly StaffContext _context;
        public HomeController(ILogger<HomeController> logger, StaffContext context)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            Debug.WriteLine("good to go");
            var staff = _context.Staff.ToList();
            var stamp = _context.Stamp.OrderByDescending(o=> o.ResumedAt).ToList();
            ViewBag.Staff = staff;
            ViewBag.Stamp = stamp;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
