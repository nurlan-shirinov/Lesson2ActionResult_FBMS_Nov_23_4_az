using Lesson2ActionResult.Entites;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lesson2ActionResult.Services
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKey(string key);
    }
}
