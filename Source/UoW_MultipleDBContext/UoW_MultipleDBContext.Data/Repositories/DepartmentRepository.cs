using UoW_MultipleDBContext.Data.DBContexts;
using UoW_MultipleDBContext.Data.Infrastructure;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Data.UnitOfWork;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Data.Repositories
{
    public class DepartmentRepository: RepositoryBase<Department>, IDepartmentRepository
    {
        private readonly SecondDbContext _dbContext;
        public DepartmentRepository(IUnitOfWork<SecondDbContext> unitOfWork)
            : base(unitOfWork.GetDbContext())
        {
            _dbContext = (_dbContext ?? (SecondDbContext)unitOfWork.GetDbContext());
        }
    }
}
