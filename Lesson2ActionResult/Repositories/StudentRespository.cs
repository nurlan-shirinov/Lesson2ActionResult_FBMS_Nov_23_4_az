using Lesson2ActionResult.Context;
using Lesson2ActionResult.Entites;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson2ActionResult.Repositories
{

    public class StudentRespository : IStudentRepository
    {

        private readonly SchoolDbContext _context;

        public StudentRespository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Student student)
        {
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
        }

        public Task<List<Student>> GetAllAsync()
        {
            return _context.Students.ToListAsync();
        }
    }
}
