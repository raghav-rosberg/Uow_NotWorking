using System.Collections.Generic;
using UoW_MultipleDBContext.Data.Infrastructure;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Data.Repositories.Interface
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<CategoryWithExpense> GetCategoryWithExpenses();
    }

    public class CategoryWithExpense
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public double TotalExpenses { get; set; }
    }
}
