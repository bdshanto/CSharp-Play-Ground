namespace WierdCoffee.Models;

public class Organization : BaseEntity
{
    public Organization()
    {
        Name = string.Empty;
    }

    public string Name { get; set; }

    public override string ToString() => $"{Id}: {Name}";
}