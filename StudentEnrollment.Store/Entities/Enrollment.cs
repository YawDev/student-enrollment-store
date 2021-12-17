using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentEnrollment.Enum;
using StudentEnrollment.Store.Entities;

namespace StudentEnrollment.Entities
{
    public class Enrollment : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid? CourseId { get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
        public LetterGrade LetterGrade { get; set; }
        public decimal GradePoint { get; set; }

        public decimal EarnedCredits { get; set; }

        public string AcademicYear { get; set; }
    
        public Semester Semester { get; set; }

        public EnrollmentStatus Status { get; set; }
    
    }
}   
