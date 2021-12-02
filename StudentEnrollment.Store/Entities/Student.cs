using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentEnrollment.Enum;
using StudentEnrollment.Store.Enums;

namespace StudentEnrollment.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public decimal TotalEarnedCredits { get; set; }
        public decimal InProgressCredits { get; set; }
        public string SSN { get; set; }
        public AttendanceStatus AcademicStatus { get; set; }
        public AcademicStanding AcademicStanding { get; set; }
        public StudentStatus StudentStatus { get; set; }
        public RegistrationStatus RegistrationStatus { get; set; }   
        public decimal GPA { get; set; }
        public string UserId {get;set;}
        public RequestUser RequestUser { get; set; }
        public List<Enrollment> CoursesEnrolled { get; set; }
    }


}