using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Pizza : Product
    {
        public string PizzaDescription{ get; set; }

        // O atributo abaixo serve para realizar o vículo n para n
        public List<PizzaIngredient> PizzaIngredients { get; set; }
    }
}
