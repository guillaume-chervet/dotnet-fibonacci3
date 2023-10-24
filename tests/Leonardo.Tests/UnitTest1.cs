using Microsoft.EntityFrameworkCore;

namespace Leonardo.Tests;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var builder = new DbContextOptionsBuilder<FibonacciDataContext>();
        var dataBaseName = Guid.NewGuid().ToString();
        builder.UseInMemoryDatabase(dataBaseName);

        var options = builder.Options;
        var fibonacciDataContext = new FibonacciDataContext(options);
        await fibonacciDataContext.Database.EnsureCreatedAsync(); 

        
        var results = await new Fibonacci(fibonacciDataContext).RunAsync(new string[] { "44", "22" });
        Assert.Equal(701408733, results[0]);
        Assert.Equal(17711, results[1]);
    }
}