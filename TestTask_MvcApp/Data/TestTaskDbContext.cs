using Microsoft.EntityFrameworkCore;
using TestTask_MvcApp.Models;

namespace TestTask_MvcApp.Data
{
    public class TestTaskDbContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public TestTaskDbContext() { }
        public TestTaskDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().Property(p => p.Name).IsRequired();
            modelBuilder.Entity<Person>().Property(p => p.Surname).IsRequired();
        }
    }
}
