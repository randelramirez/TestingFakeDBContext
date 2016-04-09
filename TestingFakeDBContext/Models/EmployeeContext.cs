using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public class EmployeeContext : DbContext, IEmployeeContext
    {
        static EmployeeContext()
        {
            Database.SetInitializer<EmployeeContext>(new DataIninitalizer());
        }

        public IDbSet<Department> Departments { get; set; }
        public IDbSet<Employee> Employees { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }


        public DbSet<TEntity> Set<TEntity>() where  TEntity: class, new()
        {
            return base.Set<TEntity>();
        }
    }
}