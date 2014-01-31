using AutoMapper;
using UoW_MultipleDBContext.Data.Repositories.Interface;
using UoW_MultipleDBContext.Entity;
using UoW_MultipleDBContext.Web.Models;

namespace UoW_MultipleDBContext.Web.Mappings
{

    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<CategoryModel, Category>();
            Mapper.CreateMap<CategoryWithExpenseModel, CategoryWithExpense>();
            Mapper.CreateMap<DepartmentModel, Department>();  
        }
    }
}