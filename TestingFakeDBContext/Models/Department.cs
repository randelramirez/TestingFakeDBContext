﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}