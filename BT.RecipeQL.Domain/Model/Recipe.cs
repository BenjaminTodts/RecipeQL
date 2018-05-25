using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace BT.RecipeQL.Domain.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
