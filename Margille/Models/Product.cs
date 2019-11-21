using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }

        // O atributo abaixo serve para realizar o vículo n para n em MargilleContext.cs
        public List<ProductOrder> ProductOrders { get; set; }

    }
}
