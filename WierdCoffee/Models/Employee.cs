namespace WierdCoffee.Models;

public class Employee : BaseEntity
{
    public Employee()
    {
        Id = 0;
        FirstName = string.Empty;
    }

    public string FirstName { get; set; }

    public override string ToString() => $"{Id}: {FirstName}";
}