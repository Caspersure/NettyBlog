namespace NettyBlog.Service.Application.Example;

public class ExampleQueryHandler
{
    /// <summary>
    /// This can use query's DbContext
    /// </summary>
    private readonly NettyBlogDbContext _dbContext;

    public ExampleQueryHandler(NettyBlogDbContext dbContext) => _dbContext = dbContext;

    [EventHandler]
    public Task GetListAsync(ExampleGetListQuery command)
    {
        //TODO:Get logic
        return Task.CompletedTask;
    }
}