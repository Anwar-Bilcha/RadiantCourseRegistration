using RadiantCourseRegistration.Models.Shared;

namespace RadiantCourseRegistration.Models
{
    public class Course : EntityBase
    {
        public string CourseId { get; set; } = string.Empty;
        public string Title { get; set; }=string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Instructor { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty ;
        public ICollection<CourseRegistration> Registrations { get; set; } = new List<CourseRegistration>();

    }

}
