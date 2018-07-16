using $ext_safeprojectname$.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using $safeprojectname$.Mapping;

namespace $safeprojectname$
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        
        public DbSet<Example> Example { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ExampleMap());
        }
    }
}
