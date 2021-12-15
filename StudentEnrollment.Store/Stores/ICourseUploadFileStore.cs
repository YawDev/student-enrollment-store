using System;
using System.Collections.Generic;
using StudentEnrollment.Entities;
using StudentEnrollment.Store.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface ICourseUploadFileStore : IStore<CourseUploadFile>
    {
        List<CourseUploadFile> GetUploadedFiles(string requestUserId);

        CourseUploadFile GetFileById(Guid id);

    }
}