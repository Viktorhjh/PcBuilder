namespace Application.DTOs;

public class MotherboardDto
{
    public Guid Id { get; set; }
    public string Socket { get; set; } = default!;
    public string Chipset { get; set; } = default!;
}