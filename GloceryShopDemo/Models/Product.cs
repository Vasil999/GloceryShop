using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloceryShopDemo.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public double Qty { get; set; }

        public decimal Sum { get => Price * (decimal)Qty; }

        public static List<Product> GetProducts()
        {
            List<Product> menu = new List<Product>()
            {
                new Product()
                {
                    Name = "cucumber",
                    Price = 2.80m,
                    Qty = 0
                },
                new Product()
                {
                    Name = "tomato",
                    Price = 3.90m,
                    Qty = 0,
                },
                new Product()
                {
                    Name = "salat",
                    Price = 1.20m,
                    Qty = 0
                },
                new Product()
                {
                    Name = "banana",
                    Price = 1.99m,
                    Qty = 0,
                },
                new Product()
                {
                    Name = "strawberry",
                    Price = 4.99m,
                    Qty = 0
                },
                new Product()
                {
                    Name = "avocado",
                    Price = 5.99m,
                    Qty = 0,
                },
                new Product()
                {
                    Name = "orange",
                    Price = 3.99m,
                    Qty = 0,
                },
            };

            return menu;
        }

        public Product Clone()
        {
            Product product = new Product();

            product.Name = this.Name;
            product.Price = this.Price;
            product.Qty = this.Qty;

            return product;
        }
    }
}
