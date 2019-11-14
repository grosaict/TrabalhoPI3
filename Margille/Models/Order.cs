using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

        public DateTime OrderData { get; set; }

        // O atributo abaixo serve para realizar o vículo n para n
        public List<ProductOrder> ProductOrder { get; set; }
    }
}
