namespace Domain.Entities;

public class Cpu : Component
{
    public string Socket { get; private set; } = default!;
    public int Cores { get; private set; }
    public int Threads { get; private set; }

    private Cpu() { }

    public Cpu(string name, string manufacturer, decimal price, int powerW,
               string socket, int cores, int threads)
        : base(name, manufacturer, price, powerW)
    {
        Socket = socket;
        Cores = cores;
        Threads = threads;
    }
}

