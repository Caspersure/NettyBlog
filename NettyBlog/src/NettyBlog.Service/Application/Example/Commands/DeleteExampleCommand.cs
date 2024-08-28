namespace NettyBlog.Service.Application.Example.Commands;

public record DeleteExampleCommand(Guid Id) : Command
{
}