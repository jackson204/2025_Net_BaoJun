using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Demo_Include;

public class CasinoCashContext : DbContext
{
    public DbSet<Member> Members { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies() // 啟用懶加載
            .UseSqlServer(
                "Server=localhost;Database=CasinoCash;User Id=sa;Password=YourStrong!Passw0rd;TrustServerCertificate=True;",
                options => options.EnableRetryOnFailure());
        optionsBuilder.LogTo(Console.WriteLine,LogLevel.Information);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Member>()
            .HasOne(m => m.User)
            .WithOne(u => u.Member)
            .HasForeignKey<Member>(m => m.UserId);

        // 添加種子資料
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Account = "user1" },
            new User { Id = 2, Account = "user2" },
            new User { Id = 3, Account = "user3" }
        );

        modelBuilder.Entity<Member>().HasData(
            new Member { Id = 1, UserId = 1, DiscountSettingId = 100 },
            new Member { Id = 2, UserId = 2, DiscountSettingId = 200 },
            new Member { Id = 3, UserId = 3, DiscountSettingId = 300 }
        );
    }
}
