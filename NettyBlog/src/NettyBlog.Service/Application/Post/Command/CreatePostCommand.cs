
using NettyBlog.Contracts.Post;

namespace NettyBlog.Service.Application.Post.Command;
 using Command = Masa.BuildingBlocks.ReadWriteSplitting.Cqrs.Commands.Command;
public record CreatePostCommand(PostCreateDto postCreateDto):Command;