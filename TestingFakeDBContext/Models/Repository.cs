using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public class Repository : IRepository
    {
        private IEmployeeContext context;

        //public Repository()
        //{
        //    this.context = new EmployeeContext();
        //}

        public Repository(IEmployeeContext context)
        {
            this.context = context;
        }


        public IQueryable<T> All<T>() where T : class, new()
        {
            return this.context.Set<T>();
        }

        public void Add<T>(T model) where T : class, new()
        {

            this.setDbSetType<T>().Add(model);
        }

        public void Update<T>(T model) where T : class, new()
        {
            this.context.Set<T>();
        }

        public void Delete<T>(T model) where T : class, new()
        {
            this.context.Set<T>();
        }

        public void Find<T>(T model) where T : class, new()
        {
            throw new NotImplementedException();
        }

        private IDbSet<T> setDbSetType<T>() where T: class, new()
        {
            return this.context.Set<T>();
        }

        public int Save()
        {
            return this.context.SaveChanges();
        }
    }
}