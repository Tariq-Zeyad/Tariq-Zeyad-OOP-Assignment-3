using System;
using System.Collections.Generic;

namespace Generics;

public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> items = new();

    public void Add(T item)
    {
        if (items.ContainsKey(item.Id))
        {
            throw new InvalidOperationException(
                $"An item with ID {item.Id} already exists."
            );
        }

        items.Add(item.Id, item);
    }

    public T? GetById(int id)
    {
        if (items.TryGetValue(id, out T? item))
        {
            return item;
        }

        return default;
    }

    public IReadOnlyDictionary<int, T> GetAll()
    {
        return items;
    }

    public void Remove(int id)
    {
        items.Remove(id);
    }
}