# Generics — Answers

## Step 2 — StudentStore vs CourseStore

Both stores are pretty similar. They use a `List` to store their objects, and both have the same four methods: `Add`, `GetById`, `GetAll`, and `Remove`.

The main difference is what they store. `StudentStore` stores `Student` objects, while `CourseStore` stores `Course` objects. A student has an `Id` and `Name`, while a course has an `Id`, `Title`, and `Price`.

---

## Step 3 — Why GetById does not compile

The compiler error is:

```text
'T' does not contain a definition for 'Id'
```

This happens because `T` can be any type. At this point, the compiler does not know that `T` has an `Id` property.

For example, `T` could be a `string`, and `string` does not have an `Id`. So the compiler cannot let us use `item.Id`.

---

## Step 7 — Why Store<string> must not compile

```csharp
// Store<string> badStore = new(); // must NOT compile
```

`Store<T>` has this constraint:

```csharp
where T : IHasId
```

This means that any type used with `Store<T>` must implement `IHasId`.

`Student` and `Course` implement `IHasId`, so they can be used with `Store<T>`.

`string` does not implement `IHasId`, so `Store<string>` does not compile.

---

## Last Question

The common name for this kind of class is a **generic repository**.

It is a reusable class that can store and manage different types of objects. The `IHasId` constraint makes sure that the objects have an `Id`, so the store can find them by ID.
