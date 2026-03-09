using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
//dotnet ef migrations add InitialCreate --project .\Infrastructure --startup-project .\API
public class PcBuilderDbContext(DbContextOptions<PcBuilderDbContext> options) : DbContext(options)
{
    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Gpu> Gpus { get; set; }
    public DbSet<Motherboard> Motherboards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(PcBuilderDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}