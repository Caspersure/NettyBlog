

namespace NettyBlog.Caller.Callers;

public class PostCaller: HttpClientCallerBase
{
    protected override string BaseAddress { get; set; } = "http://localhost:5204";
    public async Task<List<PostGetListDto>> GetListAsync()
    {
        return (await Caller.GetAsync<List<PostGetListDto>>($"/api/v1/Posts/List"))!;
    }

}
