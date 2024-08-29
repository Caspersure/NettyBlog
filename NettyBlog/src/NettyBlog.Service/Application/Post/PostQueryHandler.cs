namespace NettyBlog.Service.Application.Post;

public class PostQueryHandler
{
    private readonly NettyBlogDbContext _nettyBlogDbContext;
    public PostQueryHandler(NettyBlogDbContext nettyBlogDbContext) => _nettyBlogDbContext = nettyBlogDbContext;

    [EventHandler]
    public async Task GetListAsync(PostGetListQuery query)
    {
        var todoDbQuery = _nettyBlogDbContext.Set<PostEntity>().AsNoTracking();
        query.Result = await todoDbQuery.Select(e => new PostGetListDto
        {
            Id = e.Id.ToString(),
            Content = e.Content,
            CreateTime = e.CreateTime,
            IsTop = e.IsTop,
            Praise = e.Praise,
            Seen = e.Seen,
            Title = e.Title,
        }).ToListAsync();
    }
}