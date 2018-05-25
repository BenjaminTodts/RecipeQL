using Microsoft.AspNetCore.Mvc;
using BT.RecipeQL.Infrastructure.GraphQL.Queries;
using GraphQL;
using System.Threading.Tasks;
using BT.RecipeQL.API.Model;
using GraphQL.Types;
using System.Linq;

namespace BT.RecipeQL.API.Controllers
{
    [Route("api/[controller]")]
    public class GraphQLController : Controller
    {
        private ISchema _graphQLSchema;
        private IDocumentExecuter _documentExecuter;

        public GraphQLController(IDocumentExecuter documentExecuter)
        {
            _graphQLSchema = new Schema { Query = new RootGraphQLQuery() };
            _documentExecuter = documentExecuter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            var executionOptions = new ExecutionOptions()
            {
                Schema = _graphQLSchema,
                Query = query.Query,
                OperationName = query.Operation
            };

            var queryResult = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);

            if (queryResult.Errors?.Count > 0)
            {
                return BadRequest(queryResult.Errors.Select(e => e.Message));
            }

            return Ok(queryResult);
        }
    }
}