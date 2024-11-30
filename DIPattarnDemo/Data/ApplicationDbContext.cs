using DIPattarnDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace DIPattarnDemo.Data
{
        public class ApplicationDbContext : DbContext
        {
            // override configuration that we need at app level
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {

            }

            // LINQ  --> conversion DBset --> SQL  -> exec
            // Entity <Employee> 
            public DbSet<Employee>? Employees { get; set; }
        public DbSet<Student>? Students { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


    }

}

