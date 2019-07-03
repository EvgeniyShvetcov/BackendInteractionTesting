using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Repositories.Interfaces;

namespace Database.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ContosoUniversityContext _context;
        public StudentRepository(ContosoUniversityContext context)
        {
            _context = context;
        }
        public IEnumerable<Student> GetAll()
        {
            return _context.Students;
        }

        public IQueryable<Student> GetQuery()
        {
            return _context.Students;
        }
    }
}