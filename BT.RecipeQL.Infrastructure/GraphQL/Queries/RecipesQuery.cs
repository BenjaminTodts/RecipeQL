using GraphQL.Types;
using BT.RecipeQL.Domain.Model;
using BT.RecipeQL.Infrastructure.GraphQL.Types;

namespace BT.RecipeQL.Infrastructure.GraphQL.Queries
{
    public static class RecipesQuery
    {
        public static void Bootstrap(ObjectGraphType rootQuery)
        {
            rootQuery.Field<ListGraphType<RecipeType>>("recipes", resolve: context => new Recipe[] { new Recipe { Name = "Mac 'n Cheese" } });
        }
    }
}
