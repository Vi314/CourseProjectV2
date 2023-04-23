using Entity.Entity;
using MVC.Areas.Entities.Models.MapperAbstract;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Models.MapperConcrete
{
	public class DealerStocksMapper : IDealerStocksMapper
	{
		public DealerStockDTO FromDealerStock(DealerStocks dealerStocks, IEnumerable<Product> products,IEnumerable<Dealer> dealers)
		{
			DealerStockDTO dealerStockDTO = new DealerStockDTO
			{
				Id = dealerStocks.Id,
				Amount = dealerStocks.Amount,
			};
			if (dealerStocks.ProductId != null)
			{
				dealerStockDTO.ProductName = products.Where(x => x.Id == dealerStocks.ProductId).Select(x => x.ProductName).FirstOrDefault();
			};
			if (dealerStocks.DealerId != null)
			{
				dealerStockDTO.DealerName = dealers.Where(x => x.Id == dealerStocks.DealerId).Select(x => x.Name).FirstOrDefault();
			};
			return dealerStockDTO;
		}

		public DealerStocks ToDealerStock(DealerStockDTO dealerStocksDTO, IEnumerable<Product> products, IEnumerable<Dealer> dealers)
		{
			DealerStocks dealerStocks = new DealerStocks
			{
				Id = dealerStocksDTO.Id,
				Amount = dealerStocksDTO.Amount,
				ProductId = products.Where(x => x.ProductName == dealerStocksDTO.ProductName).Select(x => x.Id).FirstOrDefault(),
				DealerId = dealers.Where(x => x.Name == dealerStocksDTO.DealerName).Select(x => x.Id).FirstOrDefault(),
			};
			return dealerStocks;
		}
	}
}
