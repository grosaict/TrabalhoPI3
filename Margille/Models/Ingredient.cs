using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public Boolean IndAvailable { get; set; }

        // O atributo abaixo serve para realizar o vículo n para n
        public List<PizzaIngredient> PizzaIngredients { get; set; }

    }
}
