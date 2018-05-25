using System.Collections.Generic;
using BT.RecipeQL.Domain.Model;
using BT.RecipeQL.Infrastructure.GraphQL.Types;
using GraphQL.Types;

namespace BT.RecipeQL.Infrastructure.GraphQL.Queries
{
    public static class RecipeQuery
    {
        public static void Bootstrap(ObjectGraphType rootQuery)
        {
            rootQuery.Field<RecipeType>("recipe", resolve: context => 
                new Recipe { Name = "Mac 'n Cheese", Ingredients = new List<Ingredient> { 
                    new Ingredient { Name = "Macaroni" },
                    new Ingredient { Name = "Cheese", Description = "Emmentaler" } } });
        }
    }
}
