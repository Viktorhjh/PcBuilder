namespace Core.Entities;

public class Motherboard : Component
{
    public string Socket { get; private set; } = default!;
    public string Chipset { get; private set; } = default!;

    private Motherboard() { }
    public static Motherboard Create(string socket, string chipset)
    {
        return new Motherboard
        {
            Id = Guid.NewGuid(),
            Socket = socket,
            Chipset = chipset
        };
    }

    public void Update(string socket, string chipset)
    {
        Socket = socket;
        Chipset = chipset;
    }


    public Motherboard(string name, string manufacturer, decimal price, int powerW,
                       string socket, string chipset)
        : base(name, manufacturer, price, powerW)
    {
        Socket = socket;
        Chipset = chipset;
    }
}
