using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFakeDBContext.Models
{
    public interface IEmployeeContext
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class, new();

        IDbSet<Department> Departments { get; }

        IDbSet<Employee> Employees { get; }

        int SaveChanges();
    }
}
