using System.Linq;
using Database.Models;
using Database.Repositories.Interfaces;
using GraphQL.Types;

namespace GraphQLApi.Types
{
    public class StudentType : ObjectGraphType<Student>
    {
        public StudentType(IStudentRepository repository)
        {
            Field(x => x.Id);
            Field(x => x.LastName);
            Field(x => x.FirstMidName);
            Field(x => x.FullName);
            Field(x => x.EnrollmentDate);
            Field<ListGraphType<EnrollmentType>>("enrollments");
        }
    }

    public class EnrollmentType : ObjectGraphType<Enrollment>
    {
        public EnrollmentType()
        {
            Field(x => x.EnrollmentID);
            Field(x => x.StudentID);
            Field<StudentType>(nameof(Enrollment.Student));
        }
    }
}