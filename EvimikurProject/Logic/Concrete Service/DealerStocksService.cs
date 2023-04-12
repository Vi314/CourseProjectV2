using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entity;
using Logic.Abstract_Service;
using Logic.Repository;

namespace Logic.Concrete_Service
{
    public class DealerStocksService:IDealerStocksService
    {
        private readonly IRepository<DealerStocks> _repository;

        public DealerStocksService(IRepository<DealerStocks> repository)
        {
            _repository = repository;
        }
        public string CreateDealerStocks(DealerStocks dealerStocks)
        {
            try
            {
                return _repository.Create(dealerStocks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return e.Message;
            }
        }

        public string UpdateDealerStocks(DealerStocks dealerStocks)
        {
            try
            {
                return _repository.Update(dealerStocks);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return e.Message;
            }
        }

        public string DeleteDealerStocks(int id)
        {
            try
            {
                return _repository.Delete(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return e.Message;
            }
        }

        public IEnumerable<DealerStocks> GetDealerStocks()
        {
            return _repository.GetAll();
        }
    }
}
