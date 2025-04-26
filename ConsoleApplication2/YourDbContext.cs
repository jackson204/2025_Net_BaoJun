using System.Data.Entity;

namespace ConsoleApplication2
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(string connectionString) : base(connectionString)
        {
        }
   
        public DbSet<WithdrawalTimeRange> WithdrawalTimeRanges { get; set; }
    
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure the entity
            modelBuilder.Entity<WithdrawalTimeRange>()
                .ToTable("WithdrawalTimeRange").HasKey(w => w.Id); // Set Id as primary key
        
        
            modelBuilder.Entity<Blog>()
                .ToTable("Blog")
                .HasMany(b => b.Posts)
                .WithRequired(p => p.Blog)
                .HasForeignKey(p => p.BlogId);
        
            modelBuilder.Entity<Post>()
                .ToTable("Post")
                .HasKey(p => p.PostId);
        
            base.OnModelCreating(modelBuilder);
        }

    }
}
