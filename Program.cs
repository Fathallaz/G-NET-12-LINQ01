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
            var result = Source.ProductList.Where(p => p.Category == "Seafood")
                        .Select(p => new { p.ProductName, p.UnitPrice });


            #endregion
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
