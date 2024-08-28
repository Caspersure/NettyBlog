using NettyBlog.Service.DataAccess.Entities;

namespace NettyBlog.Service.DataAccess;

public class NettyBlogDbContext : MasaDbContext
{
    //public DbSet<UserEntity> { get; set; }

    public NettyBlogDbContext(MasaDbContextOptions<NettyBlogDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreatingExecuting(ModelBuilder modelBuilder)
    {
        base.OnModelCreatingExecuting(modelBuilder);
        ConfigEntities(modelBuilder);
    }

    private static void ConfigEntities(ModelBuilder modelBuilder)
    {

        var todoBuilder =
            modelBuilder.Entity<PostEntity>().Property(e => e.Title).HasMaxLength(128);
    }
}