using AcademicPerformanceSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AcademicPerformanceSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<StudentData> StudentData { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
