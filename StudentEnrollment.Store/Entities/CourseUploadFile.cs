using System;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Entities
{
    public class CourseUploadFile : BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime UploadDate { get; set; }

        public string RequestUserId { get; set; }
        
        public string FileName { get; set; }

        public string Content { get; set; }
        
        public string Extension { get; set; }
    }
}