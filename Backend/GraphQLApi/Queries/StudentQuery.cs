using System.Collections.Generic;
using System.Linq;
using Database.Repositories.Interfaces;
using GraphQL.Types;
using GraphQLApi.Types;
using Microsoft.EntityFrameworkCore;

namespace GraphQLApi.Queries
{
    public class StudentQuery : ObjectGraphType
    {
        public StudentQuery(IStudentRepository studentRepository)
        {
            Field<ListGraphType<StudentType>>("students",
                arguments: new QueryArguments(new List<QueryArgument>()
                {
                    new QueryArgument<IdGraphType>()
                    {
                        Name = "studentId",
                    }
                }),
                resolve: context =>
                {
                    var studentId = context.GetArgument<int?>("studentId");
                    var query = studentRepository.GetQuery();
                    if (studentId.HasValue)
                        query = query.Where(student => student.Id == studentId);

                    return query.Include(s => s.Enrollments)
                        .ToListAsync();
                });
        }
    }
}