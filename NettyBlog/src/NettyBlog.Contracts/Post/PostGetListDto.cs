namespace NettyBlog.Contracts.Post;

public class PostGetListDto
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public long Seen { get; set; }
    public long Praise { get; set; }
    public bool IsTop { get; set; }
    public DateTime CreateTime { get; set; }
}
