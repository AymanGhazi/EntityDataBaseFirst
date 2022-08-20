// See https://aka.ms/new-console-template for more information

using EntityDataBaseFirst.Data;
using EntityDataBaseFirst.Models;
using Microsoft.EntityFrameworkCore;

//Console.WriteLine("Hello, World!");

internal class Program
{
    private static void Main(string[] args)
    {
        var context = new ApplicationDbContext();
        // var Stocks = context.Stocks.Where(x => x.Id > 50 && x.Name.StartsWith("z")).ToList();
        //var Stocks = context.Stocks.All(x => x.Id > 500);
        // var Stocks = context.Stocks.Where(x => x.Id > 950).ToList().Prepend(new Stock { Id = 1001, Name = "Test" });

        // var Stocks = context.Stocks.OrderBy(x => x.Industry).ThenBy(x => x.Balance).ToList();
        //Console.WriteLine(Stocks);

        // var Stocks = context.Stocks.Select(m => new { StockID = m.Id, StockName = m.Name }).ToList();
        //var Stocks = context.Stocks.Select(m => new { m.Name }).Distinct().ToList();
        // var Stocks = GetDate(5, 20);
        // var Stocks = context.Stocks.GroupBy(m => m.Industry).Select(m => new { industry = m.Key, count = m.Count(), sum = m.Sum(m => m.Id) }).OrderByDescending(m => m.count);
        // context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        // var Stock = context.Stocks.SingleOrDefault(x => x.Id == 1);
        // Stock.Name = "Ayman";
        // context.SaveChanges();
        // Console.WriteLine(Stock.Name);

        var Post = new Stock
        {
            Id = 5,
            Balance = "$5566",
            Industry = "Hello Ayman",
            Name = "Ayman",
            Sector = "Kafr"

        };
     
        context.UpdateRange(Post);
        context.Entry(Post).Property(p => p.Symbol).IsModified = false;
        context.SaveChanges();
        var stock = context.Stocks.SingleOrDefault(x => x.Id == 5);
        System.Console.WriteLine(stock.Symbol);

        // foreach (var Stock in Stocks)
        // {
        //     Console.WriteLine($"Key = '{Stock.industry}' and count : {Stock.count} and Sum={Stock.sum}");
        // }
    }
    public static List<Stock> GetDate(int pageNumber, int pageSize)
    {
        var _context = new ApplicationDbContext();
        return _context.Stocks.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
    }


}