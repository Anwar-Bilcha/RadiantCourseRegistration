using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RadiantCourseRegistration.Data;
using RadiantCourseRegistration.Models;

namespace RadiantCourseRegistration.Pages.Courses { 
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
            Course = new();
        }

        [BindProperty]
        public Course Course { get; set; }

        public IActionResult OnGet(string id)
        {
            Course =  _context.Courses.Find(id)??new();

            if (Course == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var courseToDelete =  _context.Courses.Find(id);

            if (courseToDelete != null)
            {
                _context.Courses.Remove(courseToDelete);
                 _context.SaveChanges();
            }

            return RedirectToPage("/Courses");
        }
    }

}
