# Collections — Answers

## Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary

### IReadOnlyDictionary<TKey, TValue>

`IReadOnlyDictionary<TKey, TValue>` is an interface used for reading key-value pairs. It allows us to access the values using their keys, but it does not provide methods for adding or removing items.

The main idea is that if a method returns an `IReadOnlyDictionary`, the caller can read the data without getting direct access to operations that change the dictionary.

### IReadOnlyDictionary vs Dictionary

`Dictionary<TKey, TValue>` is a concrete collection that we can use to store, add, remove, and update key-value pairs.

`IReadOnlyDictionary<TKey, TValue>` is mainly used when we want to expose dictionary data for reading only. For example, if a public method returns a price list, I may want the caller to see the prices but not add or remove prices from the collection.

So, using `IReadOnlyDictionary` in a public method can help protect the collection and make it clear that the caller is only supposed to read the data.

### SortedDictionary<TKey, TValue>

`SortedDictionary<TKey, TValue>` is a collection that stores data as key-value pairs and keeps the keys sorted.

The important difference from a normal `Dictionary` is that `SortedDictionary` maintains the keys in sorted order when the collection is enumerated.

### SortedDictionary vs Dictionary

A `Dictionary<TKey, TValue>` is mainly useful when I need to find a value using its key quickly.

A `SortedDictionary<TKey, TValue>` also allows lookup by key, but it keeps the keys sorted. This makes it useful when the order of the keys is important.

The trade-off is that `SortedDictionary` generally has slower lookup and insertion than a hash-based `Dictionary`, because maintaining the sorted structure has an extra cost.

I would choose `Dictionary` when fast lookup is the main requirement. I would choose `SortedDictionary` when I need both key-based access and sorted keys.

### Sources

* [Microsoft Learn — IReadOnlyDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ireadonlydictionary-2)
* [Microsoft Learn — SortedDictionary<TKey, TValue>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2)
* [Microsoft Learn — Selecting a Collection Class](https://learn.microsoft.com/en-us/dotnet/standard/collections/selecting-a-collection-class)

---

## Task 2.2 — Pick the Collection

### S1 — Find a student by national ID

**Collection:** `Dictionary<TKey, TValue>`

I would use a `Dictionary` because the national ID can be used as the key. This makes it suitable for finding a student by ID many times without searching through all students.

### S2 — Keep the tags of a course without duplicates

**Collection:** `HashSet<T>`

I would use a `HashSet` because it stores unique values. If the same tag is added again, it will not be stored as another duplicate item.

### S3 — Keep a student's grades in the order they were entered

**Collection:** `List<T>`

I would use a `List` because it keeps the items in their insertion order and allows duplicate values. This means the same grade can appear more than once.

### S4 — Return the course price list so callers can only read it

**Collection:** `IReadOnlyDictionary<TKey, TValue>`

I would use `IReadOnlyDictionary` because the caller needs to read the prices, but should not be able to add or remove items through the returned collection.

### S5 — Timetable keyed by session start time and always printed in time order

**Collection:** `SortedDictionary<TKey, TValue>`

I would use a `SortedDictionary` because the session start time can be used as the key, and the keys are kept sorted. This makes it suitable for printing the sessions in time order.

### S6 — Return results that the caller may loop over once and stop early

**Collection:** `IEnumerable<T>`

I would use `IEnumerable<T>` because it represents a sequence that can be processed one item at a time. The caller can stop iterating when it has enough results instead of needing to process all the results first.
