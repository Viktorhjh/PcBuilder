using Application.Common.Interfaces;
using Application.Services;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Scalar.AspNetCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddDbContext<PcBuilderDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMotherboardRepository, MotherboardRepository>();
builder.Services.AddScoped<IMotherboardService, MotherboardService>();

WebApplication app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference(options =>
    {
        options.WithTitle("Scalar Example API")
            .WithDefaultHttpClient(ScalarTarget.CSharp, ScalarClient.HttpClient);
        options.WithTheme(ScalarTheme.DeepSpace);
    });

}

app.MapGet("/", () => Results.Redirect("/scalar"))
   .ExcludeFromDescription();

app.MapControllers();
app.Run();
