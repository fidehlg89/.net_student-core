using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using students_core.Models;

namespace students_core
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<City> City { get; set; }
    }
}