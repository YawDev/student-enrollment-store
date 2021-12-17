using System;

namespace StudentEnrollment.Store.Entities
{
    public class SyncStudentDataLog 
    {
        public Guid Id { get; set; }
        public DateTime TimeGenerated { get; set; }
        public Guid StudentId { get; set; }
        
    }
}