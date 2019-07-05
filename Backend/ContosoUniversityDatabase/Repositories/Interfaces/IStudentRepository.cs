using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;

namespace Database.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IQueryable<Student> GetQuery();
        Task<Student> AddStudent(Student student);
        Task<Student> DeleteStudent(int studentId);
        Task<bool> UpdateStudent(Student student);
    }
}