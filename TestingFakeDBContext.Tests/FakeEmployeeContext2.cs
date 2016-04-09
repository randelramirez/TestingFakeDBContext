using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFakeDBContext.Models;

namespace TestingFakeDBContext.Tests
{
    public class FakeEmployeeContext2 : FakeDbContext, IEmployeeContext
    {
        public IDbSet<Department> x;

        public FakeEmployeeContext2()
        {
            this.Departments = new TestDbSet<Department>();
            //this.AddFakeDbSet<Department, FakeDepartmentSet>();
            this.x = this.Departments;
            AddFakeDbSet<Department, TestDbSet<Department>>(this.Departments);
            //AddFakeDbSet<Employee, FakeEmployeeSet>();

        }

        public IDbSet<Department> Departments { get; set; }

        public IDbSet<Employee> Employees { get; set; }

    }
}
