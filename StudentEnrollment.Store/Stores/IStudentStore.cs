using System;
using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IStudentStore : IStore<Student>
    {
        Student GetByUserId(string userId);

        Student GetById(Guid Id);
    }
}