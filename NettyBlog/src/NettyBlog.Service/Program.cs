var builder = WebApplication.CreateBuilder(args);

var app = builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen(options =>
    {
        options.SwaggerDoc("v1",
            new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "NettyBlogApp", Version = "v1",
                Contact = new Microsoft.OpenApi.Models.OpenApiContact { Name = "NettyBlogApp", }
            });
        foreach (var item in Directory.GetFiles(Directory.GetCurrentDirectory(), "*.xml"))
            options.IncludeXmlComments(item, true);
        options.DocInclusionPredicate((docName, action) => true);
    })
    .AddEventBus()
    .AddMasaDbContext<NettyBlogDbContext>(opt => { opt.UseMySQL(); })
    .AddAutoInject()
    .AddServices(builder, option => option.MapHttpMethodsForUnmatched = new string[] { "PostEntity" });

app.UseMasaExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger().UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "NettyBlogApp"));

    #region MigrationDb

    using var context = app.Services.CreateScope().ServiceProvider.GetService<NettyBlogDbContext>();
    {
        context!.Database.EnsureCreated();
    }

    #endregion
}

app.Run();