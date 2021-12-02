using System;
using System.Collections.Generic;
using StudentEnrollment.Store.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IUploadCoursesLogStore : IStore<UploadCoursesLog>
    {
        List<UploadCoursesLog> GetByAdminId(Guid id);

        UploadCoursesLog GetById(Guid id);
    }
}