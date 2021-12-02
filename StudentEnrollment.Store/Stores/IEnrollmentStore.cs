using System;
using System.Collections.Generic;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IEnrollmentStore : IStore<Enrollment>
    {
        List<Enrollment> GetAllEnrollmentsByStudent(Guid studentId);

        List<Enrollment> GetAllEnrollmentsByUser(string userId);

        Enrollment GetById(Guid Id);


    }
}