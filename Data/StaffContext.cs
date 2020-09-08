using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Attendance.Models;

namespace Attendance.Data
{
    public class StaffContext : DbContext
    {
        public StaffContext(DbContextOptions<StaffContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staff { get; set; }
        public DbSet<Resume> Stamp { get; set; }

    }
}
