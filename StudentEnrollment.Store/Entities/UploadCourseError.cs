using System;
using StudentEnrollment.Enum;

namespace StudentEnrollment.Store.Entities
{
    public class UploadCourseError : BaseEntity
    {
        public Guid Id { get; set; }
        public string ErrorMessage { get; set; }
        public UploadCoursesLog UploadCourseLog { get; set; } 
        public Guid LogId { get; set; }
 
    }
}