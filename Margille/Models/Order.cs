using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Order
    {
        public int IdOrder{ get; set; }
        public int IdClient { get; set; }
        public DateTime OrderData { get; set; }
        public ProductOrder[] ProductsOrder { get; set; }
        public PizzaOrder[] PizzasOrder { get; set; }
    }
}
