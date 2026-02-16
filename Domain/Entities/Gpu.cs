namespace Domain.Entities;

public class Gpu : Component
{
    public int MemoryGb { get; private set; }

    private Gpu() { }

    public Gpu(string name, string manufacturer, decimal price, int powerW,
               int memoryGb)
        : base(name, manufacturer, price, powerW)
    {
        MemoryGb = memoryGb;
    }
}

