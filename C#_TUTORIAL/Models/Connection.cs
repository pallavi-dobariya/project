using Microsoft.EntityFrameworkCore;
using C__TUTORIAL.Models;
using MySql.EntityFrameworkCore.Extensions;

namespace C__TUTORIAL
{
  public class Connection : DbContext
  {
    public DbSet<registration> registration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=c_tutorial;user='root';password=''");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      

      modelBuilder.Entity<registration>(entity =>
      {       
      
        entity.HasKey(e => e.id);
        entity.Property(e => e.FirstName);
        entity.Property(e => e.LastName);
        entity.Property(e => e.UserName);
        entity.Property(e => e.Password);
        entity.Property(e => e.Email);
        entity.Property(e => e.Address);
      });
    }
  }
}
