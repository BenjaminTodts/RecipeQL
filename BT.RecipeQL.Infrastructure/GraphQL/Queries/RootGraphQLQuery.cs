using GraphQL.Types;

namespace BT.RecipeQL.Infrastructure.GraphQL.Queries
{
    public class RootGraphQLQuery : ObjectGraphType
    {
        public RootGraphQLQuery()
        {
            RecipeQuery.Bootstrap(this);
            RecipesQuery.Bootstrap(this);
        }
    }
}
