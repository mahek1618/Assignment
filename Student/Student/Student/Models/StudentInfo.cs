using System;
using System.Collections.Generic;

namespace Student.Models
{
    public partial class StudentInfo
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string EmailAddress { get; set; }
        public string Course { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
