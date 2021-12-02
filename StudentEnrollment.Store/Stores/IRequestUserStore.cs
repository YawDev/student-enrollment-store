using StudentEnrollment.Entities;

namespace StudentEnrollment.Store.Stores
{
    public interface IRequestUserStore : IStore<RequestUser>
    {
        RequestUser GetByUsername(string name);
        RequestUser GetByEmail(string email);
    }
}