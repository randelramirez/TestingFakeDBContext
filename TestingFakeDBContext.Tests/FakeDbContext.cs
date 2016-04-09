using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingFakeDBContext.Tests
{
    public interface IFakeDbContext 
    {
        DbSet<T> Set<T>() where T : class, new();

        void AddFakeDbSet<TEntity, TFakeDbSet>()
            where TEntity : class, new()
            where TFakeDbSet : DbSet<TEntity>, IDbSet<TEntity>, new();
    }

    public abstract class FakeDbContext
    {
        #region Private Fields
        private readonly Dictionary<Type, object> _fakeDbSets;
        #endregion Private Fields
        protected FakeDbContext()
        {
            _fakeDbSets = new Dictionary<Type, object>();
        }

        public int SaveChanges() { return default(int); }

      
        //public Task<int> SaveChangesAsync(CancellationToken cancellationToken) { return new Task<int>(() => default(int)); }

        //public Task<int> SaveChangesAsync() { return new Task<int>(() => default(int)); }

        public void Dispose() { }

        public DbSet<T> Set<T>() where T : class, new() { return ((DbSet<T>)_fakeDbSets[typeof(T)]); }

        public void AddFakeDbSet<TEntity, TFakeDbSet>(IDbSet<TEntity> value)
            where TEntity : class, new()
            where TFakeDbSet : DbSet<TEntity>
        {
            var fakeDbSet = Activator.CreateInstance<TFakeDbSet>();
            fakeDbSet = (value as TFakeDbSet);
            //fakeDbSet.Add(new TEntity());
            _fakeDbSets.Add(typeof(TEntity), fakeDbSet);
        }

        public void SyncObjectsStatePostCommit() { }
    }
}
