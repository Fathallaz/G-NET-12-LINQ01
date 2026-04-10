using G_NET_12_LINQ01.Models;

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






            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
