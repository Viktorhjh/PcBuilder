using Core.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

public class MotherboardRepository : IMotherboardRepository
{
    private readonly PcBuilderDbContext _dbContext;

    public MotherboardRepository(PcBuilderDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Motherboard>> GetAllAsync()
    {
        return await _dbContext.Motherboards.ToListAsync();
    }

    public async Task<Motherboard?> GetByIdAsync(Guid id)
    {
        return await _dbContext.Motherboards.FindAsync(id);
    }

    public async Task AddAsync(Motherboard motherboard)
    {
        await _dbContext.Motherboards.AddAsync(motherboard);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Motherboard motherboard)
    {
        _dbContext.Motherboards.Update(motherboard);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Motherboard motherboard)
    {
        _dbContext.Motherboards.Remove(motherboard);
        await _dbContext.SaveChangesAsync();
    }
}