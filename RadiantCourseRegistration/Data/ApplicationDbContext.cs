using Microsoft.EntityFrameworkCore;
using RadiantCourseRegistration.Models;

namespace RadiantCourseRegistration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Course>().HasData(new List<Course>
        {
            new Course { CourseId = "201", Title = "ASP.NET Core Basics", Description = "Learn the fundamentals of ASP.NET Core.", Instructor = "Anwar Bilcha", Duration = "6 Weeks", CreatedBy ="Admin" },
            new Course { CourseId = "302", Title = "Entity Framework Core", Description = "Master EF Core for data access.", Instructor = "Birhan Nega Smith", Duration = "4 Weeks",CreatedBy ="Admin" },
            new Course { CourseId = "403", Title = "Blazor Web Development", Description = "Build interactive web apps with Blazor.", Instructor = "Kibru G.", Duration = "8 Weeks",CreatedBy ="Admin"}
        });
            modelBuilder.Entity<CourseRegistration>()
            .HasKey(cr => new { cr.CourseId, cr.StudentName });
           
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseRegistration> CourseRegistrations { get; set; }
    }
}
