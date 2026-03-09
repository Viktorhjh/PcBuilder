using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class PcBuilderDbContextFactory
    : IDesignTimeDbContextFactory<PcBuilderDbContext>
{
    public PcBuilderDbContext CreateDbContext(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();

        // The API project folder in this workspace is named `API` (not `PcBuilder.Api`).
        string apiPath = Path.GetFullPath(
            Path.Combine(currentDirectory, "..", "API"));

        if (!Directory.Exists(apiPath))
            throw new DirectoryNotFoundException(apiPath);

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(apiPath)
            .AddJsonFile("appsettings.json", false)
            .Build();

        string? connectionString = configuration.GetConnectionString("DefaultConnection");

        DbContextOptionsBuilder<PcBuilderDbContext> optionsBuilder = new DbContextOptionsBuilder<PcBuilderDbContext>();
        optionsBuilder.UseNpgsql(connectionString);

        return new PcBuilderDbContext(optionsBuilder.Options);
    }
}