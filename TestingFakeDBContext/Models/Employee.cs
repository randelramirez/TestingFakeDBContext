﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public Department Department { get; set; }
    }
}