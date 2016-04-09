using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestingFakeDBContext.Models
{
    public interface IRepository
    {
        IQueryable<T> All<T>() where T : class, new();

        void Add<T>(T model) where T: class, new();

        void Update<T>(T model) where T : class, new();

        void Delete<T>(T model) where T : class, new();

        void Find<T>(T model) where T : class, new();

        int Save();
    }
}