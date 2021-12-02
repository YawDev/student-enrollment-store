using System.Collections.Generic;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IInstructorStore : IStore<Instructor>
    {
        List<Instructor> GetByDepartment(string department);

        Instructor GetByUserId(string id);
        Instructor GetByFullName(string FirstName, string LastName);
    }
}