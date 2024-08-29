using System.ComponentModel.DataAnnotations;

namespace NettyBlog.Service.DataAccess.Entities;

/// <summary>
/// blog entity
/// </summary>
public class PostEntity:Entity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public long Seen { get; set; }
    public long Praise { get; set; }
    public bool IsTop { get; set; }
    public DateTime CreateTime { get; set; } = DateTime.Now;
}