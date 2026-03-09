using Application.DTOs;

namespace Application.Common.Interfaces;

public interface IMotherboardService
{
    Task<Pagination<MotherboardDto>> GetAsync(int pageIndex, int pageSize);
    Task<MotherboardDto?> GetByIdAsync(Guid id);
    Task<MotherboardDto> CreateAsync(string socket, string chipset);
    Task UpdateAsync(Guid id, string socket, string chipset);
    Task DeleteAsync(Guid id);
}