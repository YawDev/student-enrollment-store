using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentEnrollment.Store.Enums;

namespace StudentEnrollment.Entities
{
    public class Instructor
    {
        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public Department Department { get; set; }
        public string UserId {get;set;}
        public RequestUser RequestUser { get; set; }
        public List<Course> CoursesInstructed { get; set; }
                
    }
}
