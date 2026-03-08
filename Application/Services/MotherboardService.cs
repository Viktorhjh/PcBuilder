using Application.Interfaces;
using Core.Entities;
using Infrastructure.Interfaces;

namespace Application.Services;

public class MotherboardService : IMotherboardService
{
    private readonly IMotherboardRepository _repository;

    public MotherboardService(IMotherboardRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<Motherboard>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Motherboard?> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }

    public async Task<Motherboard> CreateAsync(string socket, string chipset)
    {
        var motherboard = Motherboard.Create(socket, chipset);

        await _repository.AddAsync(motherboard);

        return motherboard;
    }

    public async Task UpdateAsync(Guid id, string socket, string chipset)
    {
        Motherboard? motherboard = await _repository.GetByIdAsync(id);

        if (motherboard == null)
            throw new Exception("Motherboard not found");

        motherboard.Update(socket, chipset);

        await _repository.UpdateAsync(motherboard);
    }

    public async Task DeleteAsync(Guid id)
    {
        Motherboard? motherboard = await _repository.GetByIdAsync(id);

        if (motherboard == null)
            throw new Exception("Motherboard not found");

        await _repository.DeleteAsync(motherboard);
    }
}