namespace NettyBlog.Contracts.Post;

public class PostCreateDto
{
    public string Title { get; set; }
    public string Content { get; set; } = string.Empty;
    public long Seen { get; set; }
    public long Praise { get; set; }
    public bool IsTop { get; set; } = false;
}
