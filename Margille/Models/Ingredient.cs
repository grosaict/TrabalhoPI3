using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Ingredient
    {
        public int IdIngredient { get; set; }
        public string IngredientName { get; set; }
        public Boolean IndAvailable { get; set; }
    }
}
