using Core.Entities;

namespace Infrastructure.Interfaces;

public interface IMotherboardRepository
{
    Task<List<Motherboard>> GetAllAsync();
    Task<Motherboard?> GetByIdAsync(Guid id);
    Task AddAsync(Motherboard motherboard);
    Task UpdateAsync(Motherboard motherboard);
    Task DeleteAsync(Motherboard motherboard);
}
