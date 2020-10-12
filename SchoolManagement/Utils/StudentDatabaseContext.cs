using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Utils
{
    public class StudentDatabaseContext : DbContext
    {
        public StudentDatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
