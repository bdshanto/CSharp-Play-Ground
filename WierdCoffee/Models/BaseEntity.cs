namespace WierdCoffee.Models;

public class BaseEntity : IEntity
{
    public BaseEntity()
    {
        Id = 0;
    }
    public int Id { get; set; }
}