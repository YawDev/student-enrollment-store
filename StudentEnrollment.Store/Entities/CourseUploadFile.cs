using System;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Entities
{
    public class CourseUploadFile
    {
        public Guid Id { get; set; }

        public DateTime UploadDate { get; set; }

        public Admin Admin { get; set; }

        public string RequestId { get; set; }
        
        public string FileName { get; set; }

        public string Content { get; set; }
        
        public string Extension { get; set; }
    }
}