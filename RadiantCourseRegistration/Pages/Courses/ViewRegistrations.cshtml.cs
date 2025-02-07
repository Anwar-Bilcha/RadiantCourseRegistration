using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RadiantCourseRegistration.Data;
using RadiantCourseRegistration.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RadiantCourseRegistration.Pages.Courses
{
    
    public class ViewRegistrationsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public ViewRegistrationsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public List<CourseRegistration> Registrations { get; set; } = new List<CourseRegistration>();

        public IActionResult OnGet(string id)
        {
            Course = _context.Courses.Find(id);
                //.Include(c => c.Registrations) // Load related registrations
                //.FirstOrDefault(c => c.CourseId == courseId) ?? new();
            //if (Course == null)
            //{
            //    return NotFound();
            //}
            // Fetch registered students for this course
            Registrations =_context.CourseRegistrations
                .Where(cr => cr.CourseId == id)
                .ToList();
            return Page();
        }
    }

}
