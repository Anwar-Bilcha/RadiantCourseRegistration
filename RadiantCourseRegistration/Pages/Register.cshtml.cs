using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadiantCourseRegistration.Models;
using Microsoft.EntityFrameworkCore;
using RadiantCourseRegistration.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
namespace RadiantCourseRegistration.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public RegisterModel(ApplicationDbContext context)
        {
            _context = context;
            Courses = _context.Courses.ToList();
            CourseNames = Courses.Select(a => a.Title).Where(a => a != null).ToList();
        }
        public string? SuccessMessage { get; set; }
        public string? ErrorMessage { get; set; }
        public Course Course { get; set; }
        public List<Course> Courses { get; set; }
        public List<string> CourseNames { get; set; } // List of courses for dropdown
        [BindProperty]
        public CourseRegistration CourseRegistration { get; set; }
        

        public void OnGet()
        {
             
            // Fetch all available courses
            CourseNames = new List<string>();
            CourseNames = _context.Courses.Select(a=>a.Title).Where(a=>a!=null).ToList();
        }

        public IActionResult OnPost()
        {
            string courseId = Courses.Where(a => a.Title == CourseRegistration.CourseName).First().CourseId;
            CourseRegistration.CourseId = courseId ;
            Console.WriteLine($"{CourseRegistration.Email} : {courseId}");
  
            // Prevent duplicate registrations
            var existingRegistration = _context.CourseRegistrations
                .FirstOrDefault(cr => cr.CourseId == CourseRegistration.CourseId && cr.StudentName == CourseRegistration.StudentName);

            if (existingRegistration != null)
            {
                ErrorMessage = "You are already registered for this course.";
                CourseNames = _context.Courses.Select(a=>a.Title).ToList();
                return Page();
            }
            _context.CourseRegistrations.Add(CourseRegistration);
             _context.SaveChanges();
            SuccessMessage = $"You have successfully registered for {CourseRegistration.CourseName} course.";
            return RedirectToPage("/Courses/ViewRegistrations", new {id = CourseRegistration.CourseId});
        }

        //private string? getCourseId(CourseRegistration courseRegistration)
        //{
        //  return  this._context.Courses.ToList().Where(a => a.Title.ToLower() == courseRegistration.CourseName.ToLower()).First().CourseId;
        //}
    }
}
