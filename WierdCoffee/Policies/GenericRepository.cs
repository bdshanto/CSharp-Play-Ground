using WierdCoffee.Models;

namespace WierdCoffee.Policies;

public class GenericRepository<T> where T: IEntity
{
    protected readonly List<T> _items = new();

    public T GetById(int id)
    {
        return _items.Single(c => c.Id == id);
    }
    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public IList<T> GetItems()
    {
        return _items;
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.Write(item + "\n");
        }
    }

    public int Id { get; set; }
}

public class GenericRepositoryRemove<T> : GenericRepository<T> where T: IEntity
{
    public void Remove(T item)
    {
        _items.Remove(item);
    }
}