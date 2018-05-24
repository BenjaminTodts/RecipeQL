using GraphQL.Types;
using BT.RecipeQL.Domain.Model;

namespace BT.RecipeQL.Infrastructure.GraphQL.Types
{
    public class IngredientType : ObjectGraphType<Ingredient>
    {
        public IngredientType()
        {
            Field(i => i.Name, nullable: false);
            Field(i => i.Description, nullable: true);
        }
    }
}
