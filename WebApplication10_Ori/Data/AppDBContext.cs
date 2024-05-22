using Microsoft.EntityFrameworkCore;
using WebApplication10a.Models;

namespace WebApplication10a.Data
{
public class AppDBContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; }
    
    public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) {}
    
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        //builder.AddCreatedUpdatedInterceptor();
        //base.OnConfiguring(builder);
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Blog>();
        
        builder.Entity<Blog>().Ignore(b => b.LoadedFromDatabase);
        /*builder.Entity<Blog>().HasNoKey();
        builder.Entity<Blog>()
            .Property(b => b.Url)
            .HasMaxLength(500);*/
    }

//public DbSet<Blog> Blog { get; set; } = default!;
}
}