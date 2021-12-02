using System;
using System.Collections.Generic;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IDepartmentStore : IStore<Department>
    {
        Department GetByName(string name);

        Department GetById(Guid id);

        List<Department> GetAllDepartmentsWithCourses();

        Department GetDetailsByName(string name);
    }
}