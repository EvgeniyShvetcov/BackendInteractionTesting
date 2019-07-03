using System.Collections.Generic;
using System.Linq;
using Database.Models;

namespace Database.Repositories.Interfaces
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll();
        IQueryable<Student> GetQuery();
    }
}