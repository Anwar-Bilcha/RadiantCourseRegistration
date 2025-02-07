using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RadiantCourseRegistration.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using Microsoft.EntityFrameworkCore;
    using RadiantCourseRegistration.Data;
    using RadiantCourseRegistration.Models;
    using RadiantCourseRegistration.Services;
    using System.Collections.Generic;

    public class CoursesModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CoursesModel(ApplicationDbContext context)
        {
            _context = context;
            Courses = _context.Courses.ToList();
        }
        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses.ToListAsync();
        }
    }

}
