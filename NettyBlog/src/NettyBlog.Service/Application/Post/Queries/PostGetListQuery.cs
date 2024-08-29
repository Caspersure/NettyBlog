

namespace NettyBlog.Service.Application.Post.Queries;

public record PostGetListQuery: Query<List<PostGetListDto>>
{
    public override List<PostGetListDto> Result { get; set; }
}
