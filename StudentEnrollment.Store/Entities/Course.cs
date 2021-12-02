using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEnrollment.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Abbreviation { get; set; }
        public string Section { get; set; }
        public string CourseNumber { get; set; }
        public Instructor Instructor { get; set; }
        public Department Department { get; set; }
        public decimal Credits { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int RemainingSlots {get;set;}
        public int Capacity {get;set;}
        public List<Enrollment> StudentsEnrolled { get; set; }
        public string AcademicYear { get; set; }
        public string Semester { get; set; }
        public bool IsActive { get; set; }
        
        
    }
}