using System;
using StudentEnrollment.Store.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface ISyncStudentDataLogStore : IStore<SyncStudentDataLog>
    {
        SyncStudentDataLog GetLast(Guid StudentId);
    }
}