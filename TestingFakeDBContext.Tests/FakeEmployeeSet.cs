using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFakeDBContext.Models;

namespace TestingFakeDBContext.Tests
{
    public class FakeEmployeeSet : FakeDbSet<Employee>
    {
        public override Employee Find(params object[] keyValues)
        {
            return this.SingleOrDefault(e => e.EmployeeId == (int)keyValues.Single());
        }
    }
}
