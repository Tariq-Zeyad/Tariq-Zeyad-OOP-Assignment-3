using System;
using System.Collections.Generic;

namespace Generics;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(
        this IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (pageNumber <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(pageNumber),
                "Page number must be greater than 0."
            );
        }

        if (pageSize <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(pageSize),
                "Page size must be greater than 0."
            );
        }

        int startIndex = (pageNumber - 1) * pageSize;
        int currentIndex = 0;
        int returnedItems = 0;

        foreach (T item in source)
        {
            if (currentIndex >= startIndex &&
                returnedItems < pageSize)
            {
                yield return item;
                returnedItems++;
            }

            if (returnedItems == pageSize)
            {
                yield break;
            }

            currentIndex++;
        }
    }

    public static T? FindById<T>(
        this IEnumerable<T> source,
        int id)
        where T : IHasId
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        foreach (T item in source)
        {
            if (item.Id == id)
            {
                return item;
            }
        }

        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
        this IEnumerable<T> source)
        where T : IHasId
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        Dictionary<int, T> result = new();

        foreach (T item in source)
        {
            if (result.ContainsKey(item.Id))
            {
                throw new ArgumentException(
                    $"Duplicate ID found: {item.Id}."
                );
            }

            result.Add(item.Id, item);
        }

        return result;
    }
}