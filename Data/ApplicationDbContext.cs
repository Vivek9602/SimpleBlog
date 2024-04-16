using Microsoft.EntityFrameworkCore;
using SimpleBlog.Models; // Replace SimpleBlog with your actual namespace

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; } // DbSet for each entity type

    // Optionally, override the OnModelCreating method to configure your model
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Model configuration code here
    }
}
