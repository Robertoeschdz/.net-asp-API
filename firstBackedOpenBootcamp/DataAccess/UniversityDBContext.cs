using firstBackedOpenBootcamp.Models.DataModels;
using Microsoft.EntityFrameworkCore;

namespace firstBackedOpenBootcamp.DataAccess
{
    public class UniversityDBContext: DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options): base(options)
        { 

        }

        public DbSet<User>? Users { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Chapter>? Chapter { get; set; }
    }
}
