using System;
using System.Collections.Generic;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface ICourseStore : IStore<Course>
    {
        List<Course> GetAllByInstructor(Guid instructorId);

        Course GetById(Guid id);

        List<Course> GetByName(string name);


        List<Course> GetAllByDepartment(Guid department);

        Course GetByNameAndSection(string name,string section);

        Course GetCourseForInstructor(Guid id);

        List<Course> GetCoursesByDepartmentName(string departmentName);

        List<Course> GetCoursesBySection(string section);
        
        List<Course> CompleteSearch(string courseName, string abbreviation, string section, string instructor, string department);

        


    }
}