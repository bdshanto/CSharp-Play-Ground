using System.Collections;
using System.Collections.Immutable;
using WierdCoffee.Models;

namespace WierdCoffee.Policies;

public class GenericRepository<T>: IRepository<T>
{
    private IList<T> items;

    public GenericRepository()
    {
        items =new  List<T>();
    }

    public void Add(T employee) => items.Add(employee);

    public IList<T> GetItems()
    {
        return items;
    }

   
}