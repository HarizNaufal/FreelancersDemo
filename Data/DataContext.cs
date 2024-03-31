using FreelancersApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FreelancersApp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> USERS { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>()
        //        .HasKey(u => u.id);
        //}

    }
}
