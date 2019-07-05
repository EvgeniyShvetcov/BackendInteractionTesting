using GraphQL;
using GraphQLApi.Mutations;
using GraphQLApi.Queries;

namespace GraphQLApi.Schema
{
    public class ApiSchema : GraphQL.Types.Schema
    {
        public ApiSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<StudentQuery>();
            Mutation = resolver.Resolve<StudentMutation>();
        }
    }
}