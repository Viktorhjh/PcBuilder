using Core.Entities;

namespace Application.Interfaces;

public interface IMotherboardService
{
    Task<List<Motherboard>> GetAllAsync();
    Task<Motherboard?> GetByIdAsync(Guid id);
    Task<Motherboard> CreateAsync(string socket, string chipset);
    Task UpdateAsync(Guid id, string socket, string chipset);
    Task DeleteAsync(Guid id);
}