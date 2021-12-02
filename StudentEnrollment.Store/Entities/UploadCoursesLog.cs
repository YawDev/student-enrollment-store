using System.Collections.Generic;
using System;
using StudentEnrollment.Entities;
using StudentEnrollment.Enum;

namespace StudentEnrollment.Store.Entities
{
    public class UploadCoursesLog
    {
        public Guid Id { get; set; }
        public DateTime TimeGenerated { get; set; }
        public Admin Admin { get; set; }
        public Guid AdminId { get; set; }
        public string CourseName { get; set; }
        public List<UploadCourseError> Errors { get; set; }
        public UploadStatus UploadStatus { get; set; }
    }
}