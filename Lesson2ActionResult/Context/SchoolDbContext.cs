using Lesson2ActionResult.Entites;
using Microsoft.EntityFrameworkCore;

namespace Lesson2ActionResult.Context
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
