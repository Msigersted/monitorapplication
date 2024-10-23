using monitorapplication.Models;

namespace monitorapplication.Data
{
    public class SampleData
    {
        public static void SeedData(AppDbContext database) 
        {
            database.Products.AddRange(new List<Product>
            {
                new Product {ProductId = 1, Name = "Samsung S24 Ultra", Description = "Android Based Phone", Price = 999.99M },
                new Product {ProductId = 2, Name = "Iphone 16 Pro Max", Description = "IOS Based Phone", Price = 1299.99M },
                new Product {ProductId = 3, Name = "Iphone 15 Pro Max", Description = "IOS Based Phone", Price = 1199.99M },
            });

            database.SaveChanges();
        }
    }
}
