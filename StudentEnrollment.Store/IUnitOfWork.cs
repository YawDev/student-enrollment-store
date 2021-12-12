using System;
using StudentEnrollment.Store.Stores;

namespace StudentEnrollment.Store
{
    public interface IUnitOfWork
    {
        ICourseStore CourseStore { get; }
        IStudentStore StudentStore { get; }
        IEnrollmentStore EnrollmentStore { get; }
        IInstructorStore InstructorStore { get; }
        IDepartmentStore DepartmentStore { get; }
        IRequestUserStore RequestUserStore{get;}
        IAdminStore AdminStore{get;}
        ISyncStudentDataLogStore SyncStudentDataLogStore{get;}
        ICourseUploadFileStore CourseUploadFileStore{get;}
        IUploadCoursesLogStore UploadCoursesLogStore{get;}
        IUploadCourseErrorStore UploadCourseErrorStore{get;}

        int SaveChanges();
    }
}
