using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Models;
using Database.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

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

        public async Task<Student> AddStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();

            return student;
        }

        public async Task<Student> DeleteStudent(int studentId)
        {
            var student = await _context.Students
                .AsNoTracking()
                .FirstOrDefaultAsync(item => item.Id == studentId);

            if (student == null)
                return null;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
            return student;

        }

        public async Task<bool> UpdateStudent(Student student)
        {
            _context.Students.Update(student);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}