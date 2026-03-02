using Core.Entities;
using Microsoft.EntityFrameworkCore;

//dotnet ef migrations add InitialCreate --project .\Infrastructure --startup-project .\API
public class PcBuilderDbContext(DbContextOptions<PcBuilderDbContext> options) : DbContext(options)
{
    public DbSet<Cpu> Cpus => Set<Cpu>();
    public DbSet<Gpu> Gpus => Set<Gpu>();
    public DbSet<Motherboard> Motherboards => Set<Motherboard>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(PcBuilderDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}