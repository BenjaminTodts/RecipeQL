using BT.RecipeQL.Domain.Model;
using GraphQL.Types;

namespace BT.RecipeQL.Infrastructure.GraphQL.Types
{
    public class RecipeType : ObjectGraphType<Recipe>
    {
        public RecipeType()
        {
            Field(r => r.Name, nullable: false);
            Field(r => r.Ingredients, nullable: false);
        }
    }
}
