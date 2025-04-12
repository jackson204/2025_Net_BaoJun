using Microsoft.Extensions.DependencyInjection;

namespace DI_Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        // ITestService testService = new TestService();
        // testService.Name ="TestService";
        // testService.SayHello();

        // 使用 serviceCollection();
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddScoped<ITestService, TestService2>();
        var serviceProvider = serviceCollection.BuildServiceProvider();
        var testService = serviceProvider.GetService<ITestService>()!;
        testService.Name = "TestService";
        testService.SayHello();
    }
}

internal interface ITestService
{
    public string Name { get; set; }

    public void SayHello();
}

internal class TestService : ITestService
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hello, {Name}");
    }
}

internal class TestService2 : ITestService
{
    public string Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hello, {Name} from TestService2");
    }
}
