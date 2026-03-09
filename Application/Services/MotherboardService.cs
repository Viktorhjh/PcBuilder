using Application.Common.Interfaces;
using Application.DTOs;
using Infrastructure.Interfaces;

namespace Application.Services;

public class MotherboardService(IMotherboardRepository repository) : IMotherboardService
{
    public async Task<Pagination<MotherboardDto>> GetAsync(int pageIndex, int pageSize)
    {
        return await repository.ToPagination(
            pageIndex: pageIndex,
            pageSize: pageSize,
            orderBy: x => x.Name,
            ascending: true,
            selector: x => new MotherboardDto
            {
                Id = x.Id,
                Name = x.Name,
                Chipset = x.Chipset,
                Socket = x.Socket,
                Manufacturer = x.Manufacturer,
                Price = x.Price,
                PowerConsumptionW = x.PowerConsumptionW,
                CreatedAt = x.CreatedAt,
                IsDeleted = x.IsDeleted,
                DeletedAt = x.DeletedAt
            });
    }

    public Task<MotherboardDto> CreateAsync(string socket, string chipset)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<MotherboardDto?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Guid id, string socket, string chipset)
    {
        throw new NotImplementedException();
    }
}