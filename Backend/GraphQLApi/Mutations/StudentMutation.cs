using Database.Models;
using Database.Repositories.Interfaces;
using GraphQL.Types;
using GraphQLApi.Types;
using GraphQLApi.Types.InputTypes;

namespace GraphQLApi.Mutations
{
    public class StudentMutation : ObjectGraphType
    {
        public StudentMutation(IStudentRepository repository)
        {
            Field<StudentType>(
                "createStudent",
                arguments: new QueryArguments(
                    new QueryArgument<StudentInputType>() { Name = "student" }
                ),
                resolve: context =>
                {
                    var student = context.GetArgument<Student>("student");
                    return repository.AddStudent(student).Result;
                }
            );

            Field<StudentType>(
                "deleteStudent",
                arguments: new QueryArguments()
                {
                    new QueryArgument<NonNullGraphType<StudentInputType>>(){Name = "studentId"},
                },
                resolve: context =>
                {
                    var studentId = context.GetArgument<int?>("studentId");
                    if (!studentId.HasValue)
                        return null;

                    return repository.DeleteStudent(studentId.Value);
                }
            );

            Field<StudentType>(
                "updateStudent",
                arguments: new QueryArguments()
                {
                    new QueryArgument<NonNullGraphType<StudentInputType>>(){Name = "updatedStudent"},
                },
                resolve: context =>
                {
                    var student = context.GetArgument<Student>("updatedStudent");
                    return repository.UpdateStudent(student);
                }
            );
        }
    }
}