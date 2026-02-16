namespace Domain.Entities;

public class Motherboard : Component
{
    public string Socket { get; private set; } = default!;
    public string Chipset { get; private set; } = default!;

    private Motherboard() { }

    public Motherboard(string name, string manufacturer, decimal price, int powerW,
                       string socket, string chipset)
        : base(name, manufacturer, price, powerW)
    {
        Socket = socket;
        Chipset = chipset;
    }
}
