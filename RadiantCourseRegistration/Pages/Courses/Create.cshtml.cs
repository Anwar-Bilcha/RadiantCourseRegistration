using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RadiantCourseRegistration.Data;
using RadiantCourseRegistration.Models;

namespace RadiantCourseRegistration.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
            Course = new();
        }

        [BindProperty]
        public Course Course { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Courses.Add(Course);
            _context.SaveChanges();
            return RedirectToPage("/Courses");  // Redirect to courses list after adding
        }
    }
}
