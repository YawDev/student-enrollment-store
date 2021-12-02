using System;
using Microsoft.AspNetCore.Identity;
using StudentEnrollment.Store.Enums;

namespace StudentEnrollment.Entities
{
    public class RequestUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime LastSignOn { get; set; } = DateTime.UtcNow;
        public DateTime DateSignedUp { get; set; } = DateTime.UtcNow;
        public Permissions Permission { get; set; }

    }


}