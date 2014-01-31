using System;
using System.Collections.Generic;
using UoW_MultipleDBContext.Data.DBContexts;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Data.UnitOfWork;
using UoW_MultipleDBContext.Entity;

namespace UoW_MultipleDBContext.Service.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork<SecondDbContext> _unitOfWork;
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentService(IUnitOfWork<SecondDbContext> unitOfWork, IDepartmentRepository departmentRepository)
        {
            _unitOfWork = unitOfWork;
            _departmentRepository = departmentRepository;
        }

        public IEnumerable<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public Department GetById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public void Insert(Department entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _departmentRepository.Insert(entity);
            _unitOfWork.Commit();
        }

        public void Update(Department entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _departmentRepository.Update(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Department entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _departmentRepository.Delete(entity);
            _unitOfWork.Commit();
        }
    }
}
