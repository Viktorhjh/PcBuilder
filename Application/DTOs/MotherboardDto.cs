namespace Application.DTOs;

public class MotherboardDto
{
    public Guid Id { get; set; }
    public string Socket { get; set; } = default!;
    public string Chipset { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Manufacturer { get; set; } = default!;
    public decimal Price { get; set; }
    public int PowerConsumptionW { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
}