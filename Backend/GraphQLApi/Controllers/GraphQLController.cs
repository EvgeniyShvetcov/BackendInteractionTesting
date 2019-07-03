using System;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using GraphQLApi.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphQLController : Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _documentExecutor;
        public GraphQLController()
        {

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            var inputs = query.Variables?.ToInputs();
            var executionOptions = new ExecutionOptions()
            {
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs,
            };

            var result = await _documentExecutor
                .ExecuteAsync(executionOptions);

            if (result.Errors.Any())
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}