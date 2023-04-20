using Entity.Entity;

namespace Logic.Abstract_Service
{
    public interface IDealerStocksService
    {
        string CreateDealerStocks(DealerStocks dealerStocks);
        string UpdateDealerStocks(DealerStocks dealerStocks);
        string DeleteDealerStocks(int id);
        IEnumerable<DealerStocks> GetDealerStocks();
        DealerStocks GetById(int id);

}
}