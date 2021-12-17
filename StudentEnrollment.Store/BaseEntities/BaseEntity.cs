using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollment.Store.Entities
{
    public class BaseEntity
    {
        public string CreatedBy {get;set;}
        public DateTime? CreatedOn {get;set;}
        public string LastModifiedDate {get;set;}
        public string LastModifiedBy {get;set;}
    }
}