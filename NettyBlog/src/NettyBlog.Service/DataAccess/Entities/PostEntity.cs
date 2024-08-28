namespace NettyBlog.Service.DataAccess.Entities;

public class PostEntity:Entity<Guid>
{
    public string Title { get; set; }
}