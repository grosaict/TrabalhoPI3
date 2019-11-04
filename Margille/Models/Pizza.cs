using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Pizza : Product
    {
        public string PizzaDescription{ get; set; }
        public Ingredient[] Ingredients { get; set; }
    }
}
