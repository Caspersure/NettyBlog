using Projects;

var builder = DistributedApplication.CreateBuilder(args);
//add projects to aspire
builder.AddProject<NettyBlog_Service>("api");
builder.AddProject<NettyBlog_Web>("Web");
builder.Build().Run();