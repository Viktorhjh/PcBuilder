using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

public class PcBuilderDbContext : DbContext
{
    public PcBuilderDbContext(DbContextOptions<PcBuilderDbContext> options)
        : base(options)
    {
    }

    public DbSet<Component> Components => Set<Component>();
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
