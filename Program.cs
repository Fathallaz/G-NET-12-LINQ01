using G_NET_12_LINQ01.Models;
using System.Globalization;
using System.Xml.Linq;

namespace G_NET_12_LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1 
            //            1.Get all products from the "Seafood" category.Print each
            //product's name and price.

            //Answer:
            //var result = Source.ProductList.Where(p => p.Category == "Seafood")
            //            .Select(p => new { p.ProductName, p.UnitPrice });


            #endregion

            #region Question 2 
            // 2.Get a list of only the product names from ProductList.Print
            //each name.

            //Answer:
            //var result = Source.ProductList.Select(p => p.ProductName);

            #endregion

            #region Question 3 
            //            3.Sort all products by UnitPrice(ascending). Print each
            //product's name and price.

            //Answer:
            //var result = Source.ProductList.OrderBy(p => p.UnitPrice)
            //            .Select(p => new { p.ProductName, p.UnitPrice });

            #endregion

            #region Question 4 
            //4.Get all products where UnitPrice is between 10 and 30

            //Answer:
            //var result = Source.ProductList.Where(p=> p.UnitPrice >= 10 && p.UnitPrice <= 30);

            #endregion

            #region Question 5 
            //5.Get all products that are in stock(UnitsInStock > 0) and
            //belong to the "Condiments" category.

            //Answer:
            //var result = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            #endregion

            #region Question 6 
            //            6.Create a new anonymous type with three properties:
            //● Name → the product name
            //● Price → the unit price
            //● StockStatus → a string: "Available" if UnitsInStock > 0,
            //otherwise "Out of Stock"
            //● Print the result.

            //Answer:
            //var result = Source.ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});
            //Console.WriteLine(result);




            #endregion

            #region Question 7 
            //7.Print each product's name along with its position (1-based)
            //in the list. Expected format: 1.Chai, 2.Chang, etc.

            //Answer:
            //var result = Source.ProductList.Select((p, i) => $"{i + 1}. {p.ProductName}");


            #endregion

            #region Question 8 
            //            8.Sort ProductList by Category ascending, then within each
            //category, sort by UnitPrice descending.

            //Answer:
            //var result = Source.ProductList.OrderBy(p => p.Category)
            //            .ThenByDescending(p => p.UnitPrice);


            #endregion

            #region Question 9 
            //  9.Get all products from the "Beverages" category, sorted by
            //UnitsInStock descending. Print name and stock.

            //Answer:
            //var result = Source.ProductList.Where(p => p.Category == "Beverages")
            //            .OrderByDescending(p => p.UnitsInStock)
            //            .Select(p => new { p.ProductName, p.UnitsInStock });
            #endregion






            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
