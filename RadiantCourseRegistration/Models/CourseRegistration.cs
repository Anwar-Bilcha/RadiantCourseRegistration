using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RadiantCourseRegistration.Models
{
    public class CourseRegistration
    {
        [Required]
        public string StudentName { get; set; } 

        [Required]
        public string Email { get; set; } 
        [Required]
        public string CourseId { get; set;} 

        [Required]
        public string CourseName { get; set; } 

        [Required, Range(1, 8)]
        public int Semester { get; set; }
        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;
        public Course Course { get; set; }

    }
}
