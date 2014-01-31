using System.Data.Entity;
using UoW_MultipleDBContext.Data.Infrastructure;
using UoW_MultipleDBContext.Data.Repositories;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Data.UnitOfWork
{
    public class UnitOfWork<TContext> : Disposable, IUnitOfWork<TContext>
        where TContext : DbContext, new()
    {
        public virtual void Commit()
        {
            _dataContext.SaveChanges();
        }

        private readonly DbContext _dataContext;

        public UnitOfWork()
        {
            _dataContext = new TContext();
        }

        public DbContext GetDbContext()
        {
            return _dataContext;
        }

        protected override void DisposeCore()
        {
            if (_dataContext != null)
                _dataContext.Dispose();
        }
    }
}
