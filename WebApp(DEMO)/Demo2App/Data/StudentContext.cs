using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demo2App.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<Demo2App.Models.Student> Student { get; set; }
    }
}
