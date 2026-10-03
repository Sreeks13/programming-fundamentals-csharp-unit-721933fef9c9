using System.Diagnostics;
using System.Threading.Tasks;
using Xunit;

public class LibraryTests
{
    [Fact]
    public async Task CheckoutAsync_WaitsAndReturnsBook()
    {
        var stopwatch = Stopwatch.StartNew();

        var result = await Library.CheckoutAsync("C# Fundamentals");

        stopwatch.Stop();

        Assert.Equal("Checked out: C# Fundamentals", result);
        Assert.True(stopwatch.ElapsedMilliseconds >= 900);
    }

    [Fact]
    public void Shelf_HoldsAnyType()
    {
        var intShelf = new Shelf<int>(42);
        var stringShelf = new Shelf<string>("Book");

        Assert.Equal(42, intShelf.Item);
        Assert.Equal("Book", stringShelf.Item);
    }
}