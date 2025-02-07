using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RadiantCourseRegistration.Data;
using RadiantCourseRegistration.Models;

namespace RadiantCourseRegistration.Pages.Courses
{
    

    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
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

        public IActionResult OnPost(string id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var courseToUpdate = _context.Courses.Find(id);

            if (courseToUpdate == null)
            {
                return NotFound();
            }

            courseToUpdate.Title = Course.Title;
            courseToUpdate.Description = Course.Description;
            courseToUpdate.Instructor = Course.Instructor;
            courseToUpdate.Duration = Course.Duration;

             _context.SaveChanges();

            return RedirectToPage("/Courses");
        }
    }

}
