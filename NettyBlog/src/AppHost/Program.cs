using Projects;

var builder = DistributedApplication.CreateBuilder(args);
//add projects to aspire
builder.AddProject<NettyBlog_Service>("api");
builder.AddProject<NettyBlogWeb>("web");
builder.Build().Run();