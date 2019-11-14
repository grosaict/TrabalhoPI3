using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string NameClient { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public string Pwd { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string PostCode{ get; set; }
    }
}
