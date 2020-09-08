using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Attendance.Data;
using Attendance.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Attendance.Controllers
{
    public class HandleFormController : Controller
    {
        private readonly ILogger<HandleFormController> _logger;
        private readonly StaffContext _context;
        public HandleFormController(ILogger<HandleFormController> logger, StaffContext context)
        {
            _context = context;
            _logger = logger;
        }
        [HttpPost]
        public async Task<ActionResult> Index([Bind("StaffID,ResumedAt")] Resume resume)
        {
            if (ModelState.IsValid)
            {
                _logger.LogInformation(resume.StaffID);
                _logger.LogInformation(resume.ResumedAt);
                _context.Stamp.Add(resume);
                await _context.SaveChangesAsync();
            }
            return Redirect("/");
        }


    }
}
