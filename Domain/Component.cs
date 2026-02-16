namespace Domain;

public abstract class Component : BaseEntity
{
    public string Name { get; protected set; } = default!;
    public string Manufacturer { get; protected set; } = default!;
    public decimal Price { get; protected set; }
    public int PowerConsumptionW { get; protected set; }

    protected Component() { }

    protected Component(string name, string manufacturer, decimal price, int powerW)
    {
        Name = name;
        Manufacturer = manufacturer;
        Price = price;
        PowerConsumptionW = powerW;
    }

}
