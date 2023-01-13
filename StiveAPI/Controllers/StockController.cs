using Microsoft.AspNetCore.Mvc;
using StiveAPI.Helpers;
using StiveAPI.Models;

namespace StiveAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StockController
    {
        [HttpPost(Name = "AddStock")]
        public void AddStock(int Id_article, int quantite)
        {
            using StiveController context = new();

            Stock stock = new();
            stock.Id_article= Id_article;
            stock.Quantite= quantite;

            context.Add(stock);
            context.SaveChanges();
        }

        [HttpPut(Name = "EditStock")]
        public void EditStock(int Id_stock, int Id_article, int quantite)
        {
            using StiveController context= new();

            Stock stock = context.Stocks.Where(c => c.Id_stock == Id_stock).First();
            stock.Id_article = Id_article;
            stock.Quantite= quantite;

            context.Update(stock);
            context.SaveChanges();
        }

        [HttpPut(Name = "DeleteStock")]
        public void DeleteStock(int id)
        {
            using StiveController context = new();

            Stock stock = context.Stocks.Where(c => c.Id_stock == id).First();

            context.Remove(stock);
            context.SaveChanges();
        }

        [HttpGet(Name = "GetAllStock")]
        public List<Stock> GetAllStock()
        {
            using StiveController context = new();

            List<Stock> stock = context.Stocks.ToList();
            return stock;
        }

        [HttpGet(Name = "GetStockById")]
        public Stock GetStockById(int id)
        {
            using StiveController context = new();

            Stock stock = context.Stocks.Where(c => c.Id_stock == id).First();
            return stock;
        }
    }
}
