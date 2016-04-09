using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public class DataIninitalizer : DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>()
            {
                new Employee { FirstName = "Rowan", LastName = "Miller" },
                new Employee { FirstName = "Kate", LastName = "Uptown" },
                new Employee { FirstName = "Bill", LastName = "Gates" },
                new Employee { FirstName = "Larry", LastName = "Bird" }
            };
            //base.Seed(context);

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}