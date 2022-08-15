using WierdCoffee.Models;

namespace WierdCoffee.Policies;

public interface IRepository<T>
{
    void Add(T organization);
    IList<T> GetItems();
}