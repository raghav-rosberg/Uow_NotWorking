using System.Collections.Generic;
using UoW_MultipleDBContext.Data.Infrastructure;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Service.CategoryService
{
    public interface ICategoryService : IRepository<Category>
    {
        IEnumerable<CategoryWithExpense> GetCategoryWithExpenses();
    }
}
