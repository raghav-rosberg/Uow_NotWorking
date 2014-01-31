using System;
using System.Collections.Generic;
using UoW_MultipleDBContext.Data.DBContexts;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Data.UnitOfWork;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork<FirstDbContext> _unitOfWork;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork<FirstDbContext> unitOfWork, ICategoryRepository categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }

        public IEnumerable<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public IEnumerable<CategoryWithExpense> GetCategoryWithExpenses()
        {
            return _categoryRepository.GetCategoryWithExpenses();
        }

        public void Insert(Category entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _categoryRepository.Insert(entity);
            _unitOfWork.Commit();
        }

        public void Update(Category entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _categoryRepository.Update(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Category entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _categoryRepository.Delete(entity);
            _unitOfWork.Commit();
        }
    }
}
