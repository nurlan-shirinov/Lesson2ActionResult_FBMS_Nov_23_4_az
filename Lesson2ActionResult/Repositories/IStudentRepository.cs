using Lesson2ActionResult.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson2ActionResult.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task AddAsync(Student student);
    }
}
