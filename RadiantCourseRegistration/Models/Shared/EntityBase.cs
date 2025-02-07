namespace RadiantCourseRegistration.Models.Shared
{
    public class EntityBase
    {
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.MinValue;
        public string UpdatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedOn { get; set; } 

    }
}
