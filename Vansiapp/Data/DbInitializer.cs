using API.Entities;
using System.Collections.Generic;
using System.Linq;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                    Name ="product name etc",
                    Description = "dang lam",
                    Price = 18000,
                    PictureUrl ="/images/products/boot-ang1.png",
                    Brand = "Angular",
                    Type = "Boots",
                    QuantityStock =100,

                },
                   new Product
                {
                    Name ="product name etc 2",
                    Description = "dang lam",
                    Price = 20000,
                    PictureUrl ="/images/products/boot-ang1.png",
                    Brand = "Angularss",
                    Type = "Bootsss",
                    QuantityStock =1000,

                },
                       new Product
                {
                    Name ="product name etc 3",
                    Description = "dang lam 2",
                    Price = 20002,
                    PictureUrl ="/images/products/boot-ang1.png",
                    Brand = "Angularss",
                    Type = "Bootsss",
                    QuantityStock =1000,

                },
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}
