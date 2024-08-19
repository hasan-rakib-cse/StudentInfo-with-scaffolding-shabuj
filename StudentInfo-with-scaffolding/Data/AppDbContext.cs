using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInfo_with_scaffolding.Models;

namespace StudentInfo_with_scaffolding.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentInfo_with_scaffolding.Models.Student> Student { get; set; } = default!;
    }
}
