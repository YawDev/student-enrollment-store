using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IAdminStore : IStore<Admin>
    {
        Admin GetByUserId(string userid);
    }
}