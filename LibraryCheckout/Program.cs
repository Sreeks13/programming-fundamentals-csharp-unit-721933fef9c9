using System;
using System.Threading.Tasks;

public class Shelf<T>
{
    public T Item { get; }

    public Shelf(T item)
    {
        Item = item;
    }
}

public static class Library
{
    public static async Task<string> CheckoutAsync(string book)
    {
        await Task.Delay(1000);
        return $"Checked out: {book}";
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        var result = await Library.CheckoutAsync("C# Fundamentals");
        Console.WriteLine(result);
    }
}