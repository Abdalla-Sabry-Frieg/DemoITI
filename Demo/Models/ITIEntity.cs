using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class ITIEntity:DbContext
    {
        public ITIEntity()
        {
        }
        public ITIEntity(DbContextOptions options):base(options)
        {
        }
        public DbSet<Department> Departments { get; set; }
    }
}
