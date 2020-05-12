using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloceryShopDemo.Models
{
    public class Shopping
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public string SumOfShopping { get => string.Format("{0:C}", Products.Sum(p=>p.Sum)); }

        public decimal SumOfAllProducts { get => Products.Sum(p => p.Sum); }
    }
}
