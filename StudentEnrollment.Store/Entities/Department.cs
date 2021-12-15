using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using StudentEnrollment.Store.Entities;

namespace StudentEnrollment.Entities
{
    public class Department : BaseEntity
    {
        public Guid Id { get; set; }
    
        public string Title { get; set; }

        public int NumberOfCourses { get; set; }

        public List<Instructor> Instructors { get; set; }

        public List<Course> Courses { get; set; }
        
        
    }
}   
