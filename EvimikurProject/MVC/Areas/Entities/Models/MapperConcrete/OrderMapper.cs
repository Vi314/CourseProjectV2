using Entity.Entity;
using MVC.Areas.Entities.Models.MapperAbstract;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Models.MapperConcrete
{
    public class OrderMapper : IOrderMapper
    {
        public OrderDTO FromOrder(Order order, IEnumerable<Employee> employees, IEnumerable<Dealer> dealers)
        {
            var orderDTO = new OrderDTO
            {
                Id= order.Id,
                Price= order.Price,
                OrderDate= order.OrderDate,
                DealerName = dealers.Where(x => x.Id == order.DealerId).Select(x => x.Name).FirstOrDefault(),
                EmployeeName = employees.Where(x => x.Id == order.EmployeeId).Select(x => $"{x.FirstName} {x.LastName}").FirstOrDefault(),
            };



            return orderDTO;
        }

        public Order ToOrder(OrderDTO orderDTO, IEnumerable<Employee> employees, IEnumerable<Dealer> dealers)
        {
            var order = new Order
            {
                Id= orderDTO.Id,
                OrderDate= orderDTO.OrderDate,  
                DealerId = dealers.Where(x => x.Name == orderDTO.DealerName).Select(x => x.Id).FirstOrDefault(),
                EmployeeId = employees.Where(x=> $"{x.FirstName} {x.LastName}" == orderDTO.EmployeeName).Select(x => x.Id).FirstOrDefault(),
                Price= orderDTO.Price,
            };
            return order;
        }
    }
}
