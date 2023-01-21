using Microsoft.EntityFrameworkCore;
namespace DAL;
using BOL;

public class Collectioncontext:DbContext
{
    public DbSet<Student> allstudents{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {   string conString=@"server=localhost;user=root;password=siddhant;database=test";
          optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>(entity=>
        {
            entity.HasKey(e=>e.id);
            entity.Property(e=>e.name).IsRequired();
            entity.Property(e=>e.course).IsRequired();
            entity.Property(e=>e.fee).IsRequired();


        });
        modelBuilder.Entity<Student>().ToTable("student");
    }
}