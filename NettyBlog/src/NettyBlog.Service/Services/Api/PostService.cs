namespace NettyBlog.Service.Services.Api;
public class PostService:ServiceBase
{
    /// <summary>
    /// get IEventBus service
    /// </summary>
    private IEventBus _eventBus => GetRequiredService<IEventBus>();

    /// <summary>
    /// create a new post
    /// </summary>
    /// <param name="dto"></param>
    public async Task CreateAsync(PostCreateDto dto)
    {
        var command = new CreatePostCommand(dto);

        await _eventBus.PublishAsync(command);
    }
    /// <summary>
    /// get all posts
    /// </summary>
    /// <returns></returns>
    public async Task<List<PostGetListDto>> GetListAsync()
    {
        var todoQuery = new PostGetListQuery();
        await _eventBus.PublishAsync(todoQuery);
        return todoQuery.Result;
    }

}
