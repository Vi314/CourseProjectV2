using Entity.Entity;
using MVC.Areas.Entities.Models.MapperAbstract;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Models.MapperConcrete
{
    public class OrderDetailsMapper : IOrderDetailsMapper
    {
        public OrderDetailsDTO FromOrderDetails(OrderDetails orderDetails, IEnumerable<Product> products)
        {
            var orderDetailsDTO = new OrderDetailsDTO
            {
                Amount = orderDetails.Amount,
                OrderId = orderDetails.OrderId,
                Price = orderDetails.Price,
                ProductName = products.Where(x => x.Id == orderDetails.ProductId).Select(x => x.ProductName).FirstOrDefault(),
            };
            return orderDetailsDTO;
        }

        public OrderDetails ToOrderDetails(OrderDetailsDTO orderDetailsDTO, IEnumerable<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
