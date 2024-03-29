﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.RequestModel
{
    public class StudentInfoRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public DateTime? BirthDate { get; set; }
        public int? Age { get; set; }
        public string EmailAddress { get; set; }
        public string Course { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
