using GraphQL.Types;

namespace GraphQLApi.Types.InputTypes
{
    public class StudentInputType : InputObjectGraphType
    {
        public StudentInputType()
        {
            Name = "studentInput";
            Field<IdGraphType>("id");
            Field<StringGraphType>("firstMidName");
            Field<StringGraphType>("lastName");
            Field<DateGraphType>("enrollmentDate");
            Field<ListGraphType<IdGraphType>>("enrollments");
        }
    }
}