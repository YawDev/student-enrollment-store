using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentEnrollment.Entities
{
    public class Department
    {
        public Guid Id { get; set; }
    
        public string Title { get; set; }

        public int NumberOfCourses { get; set; }

        public List<Instructor> Instructors { get; set; }

        public List<Course> Courses { get; set; }
        
        
    }
}   
