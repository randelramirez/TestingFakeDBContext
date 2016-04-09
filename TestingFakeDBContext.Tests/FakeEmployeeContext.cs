using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingFakeDBContext.Models;

namespace TestingFakeDBContext.Tests
{
    public class FakeEmployeeContext : DbContext, IEmployeeContext
    {
        Dictionary<Type, object> fakes = new Dictionary<Type, object>();

        public FakeEmployeeContext()
        {
            //this.Departments = new FakeDepartmentSet();
            this.Employees = new FakeEmployeeSet();
            this.fakes.Add(typeof(Department), this.Departments);
            
        }

        public IDbSet<Department> Departments { get;  set; }

        public IDbSet<Employee> Employees { get;  set; }

        public override int SaveChanges()
        {
            return 0;
        }

        public DbSet<TEntity> Set<TEntity>() where TEntity : class, new()
        {
            //return base.Set<TEntity>();
            return (this.fakes[typeof(TEntity)] as DbSet<TEntity>);
        }
    }
}
