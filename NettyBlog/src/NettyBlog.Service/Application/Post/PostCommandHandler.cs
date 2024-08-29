namespace NettyBlog.Service.Application.Post;

public class PostCommandHandler
{
    /// <summary>
    /// This use business DbContext
    /// </summary>
    private readonly NettyBlogDbContext _dbContext;
    /// <summary>
    /// inject DbContext
    /// </summary>
    /// <param name="dbContext"></param>
    public PostCommandHandler(NettyBlogDbContext dbContext) => _dbContext = dbContext;

    /// <summary>
    /// create post
    /// </summary>
    /// <param name="command"></param>
    [EventHandler]
    public async Task CreateAsync( CreatePostCommand command)
    {
        var todo = command.postCreateDto.Adapt<PostEntity>();
        await _dbContext.Set<PostEntity>().AddAsync(todo);
        await _dbContext.SaveChangesAsync();
    }
}
