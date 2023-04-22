using Entity.Entity;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Models.MapperAbstract
{
    public interface IEmployeeMapper
    {
        public Employee ToEmployee(EmployeeDTO dto, List<Dealer> dealers);
        public EmployeeDTO FromEmployee(Employee entity, List<Dealer> dealers);

    }
}