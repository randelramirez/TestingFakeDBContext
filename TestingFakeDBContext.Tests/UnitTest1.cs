using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingFakeDBContext.Models;
using System.Linq;
using TestingFakeDBContext.Controllers;
using System.Collections.Generic;
using Microsoft.QualityTools.Testing.Fakes;
using TestingFakeDBContext.Models.Fakes;

namespace TestingFakeDBContext.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //FakeEmployeeContext context = new FakeEmployeeContext()
            //{
            //    Employees =
            //    {
            //        new Employee { FirstName = "BBB"},
            //        new Employee { FirstName = "AAA"},
            //        new Employee { FirstName = "ZZZ"},
            //    }
            //};
            //Console.WriteLine(context.Employees.Count());
            //Console.WriteLine( context.Set<Employee>().Count());

            var context = new FakeEmployeeContext2
            {
                //Departments =
                //{
                //    new Department { Name = "BBB"},
                //    new Department { Name = "AAA"},
                //    new Department { Name = "ZZZ"},
                //}
            };
            //context.Departments.Add(new Department { Name = "BBB" });
            //Console.WriteLine(context.Departments.Count());
            context.Set<Department>().Add(new Department { });
            context.Set<Department>().Add(new Department { });
            context.Set<Department>().Add(new Department { });
            Console.WriteLine(context.Set<Department>().ToList().Count());
        }

        //[TestMethod]
        //public void IndexOrdersByName()
        //{
        //    var context = new FakeEmployeeContext
        //    {
        //        Employees =
        //        {
        //            new Employee { FirstName = "BBB"},
        //            new Employee { FirstName = "AAA"},
        //            new Employee { FirstName = "ZZZ"},
        //        }
        //    };

        //    var controller = new EmployeesController(context);
        //    var result = controller.Index2();
        //    //var x = context.Set<Employee>().Count();
        //    //Console.WriteLine(x);
        //    Assert.IsInstanceOfType(result.ViewData.Model, typeof(IEnumerable<Employee>));

        //    var employees = (IEnumerable<Employee>)result.ViewData.Model;
        //    Assert.AreEqual("AAA", employees.ElementAt(0).FirstName);
        //    Assert.AreEqual("BBB", employees.ElementAt(1).FirstName);
        //    Assert.AreEqual("ZZZ", employees.ElementAt(2).FirstName);
        //}
    }
}
