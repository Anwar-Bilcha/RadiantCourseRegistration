namespace RadiantCourseRegistration.Services
{
    using RadiantCourseRegistration.Data;
    using RadiantCourseRegistration.Models;
    using System.Collections.Generic;

    public class CourseService
    {
        private readonly ApplicationDbContext context;

        public CourseService(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }
        public List<Course> GetCourses()
        {
            return context.Courses.ToList();
        }
    }

}
