using System;
using System.Collections.Generic;
using System.Diagnostics;

const int count = 5_000_000;

var list = new List<int>(count);
var hashSet = new HashSet<int>();

for (int i = 0; i < count; i++)
{
    list.Add(i);
    hashSet.Add(i);
}

int target = count - 1;

var stopwatch = Stopwatch.StartNew();

bool listResult = list.Contains(target);

stopwatch.Stop();
long listTime = stopwatch.ElapsedTicks;

stopwatch.Restart();

bool hashSetResult = hashSet.Contains(target);

stopwatch.Stop();
long hashSetTime = stopwatch.ElapsedTicks;

Console.WriteLine($"List.Contains:    {listResult} - {listTime} ticks");
Console.WriteLine($"HashSet.Contains: {hashSetResult} - {hashSetTime} ticks");
Console.WriteLine($"Frequency: {Stopwatch.Frequency:N0} ticks/sec");


Console.WriteLine("****************************************************");


string request = "UserId:123456789";

string substring = request.Substring(7, 9);

ReadOnlySpan<char> span = request.AsSpan(7, 9);

Console.WriteLine($"Substring: {substring}");
Console.WriteLine($"Span:      {span.ToString()}");
Console.WriteLine($"Span length: {span.Length}");



Console.WriteLine("************************************************************");


var product = new Product("Laptop", 1000);

Console.WriteLine($"Is free: {product.IsFree}");
Console.WriteLine($"Name length: {product.NameLength}");

Console.WriteLine($"Static extension: {Product.Free.Name}");
Console.WriteLine($"Price: {Product.Free.Price}");