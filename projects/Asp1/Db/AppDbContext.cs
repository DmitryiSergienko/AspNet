using Microsoft.EntityFrameworkCore;

namespace Asp1.Db;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "test@test.com",
                DateOfBirth = new DateTime(1984, 05, 24)
            }
        );
    }
}