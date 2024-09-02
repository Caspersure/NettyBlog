

using Microsoft.Extensions.Options;
using NettyBlog.Contracts.Post;

namespace NettyBlog.Caller.Post;

public class PostCaller:HttpClientCallerBase
{
    protected override string BaseAddress { get; set; }

    public PostCaller(IOptions<NettyBlogCallerOptions> options)
    {
        BaseAddress = options.Value.BaseAddress;
        Prefix = "api/v1/Posts/";
    }

    public async Task<List<PostGetListDto>> GetListAsync()
    {
        return (await Caller.GetAsync<List<PostGetListDto>>($"List"));
    }
}