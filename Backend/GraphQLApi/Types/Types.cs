using Database.Models;
using GraphQL.Types;

namespace GraphQLApi.Types
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType()
        {
            Field(x => x.Id);
            Field(x => x.LastName);
            Field(x => x.FirstMidName);
            Field(x => x.FullName);
            Field(x => x.EnrollmentDate);
        }
    }
}