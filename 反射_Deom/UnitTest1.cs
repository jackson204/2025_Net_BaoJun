using System.Reflection;
using Xunit.Abstractions;

namespace 反射_Deom;

public class UnitTest1
{
    private readonly ITestOutputHelper _testOutputHelper;

    public UnitTest1(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void 查公開的屬性()
    {
        var type = typeof(StudentInfo).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        foreach (var info in type)
        {
            _testOutputHelper.WriteLine($"Name {info.Name}");
        }
    }

    [Fact]
    public void 把屬性全查出來包含私有的()
    {
        var type = typeof(StudentInfo).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var info in type)
        {
            _testOutputHelper.WriteLine($"Name {info.Name}");
        }
    }

    [Fact]
    public void 取特定的屬性()
    {
        var type = typeof(StudentInfo);
        var info = type.GetProperty("Id", BindingFlags.Instance | BindingFlags.NonPublic);
        _testOutputHelper.WriteLine($"Id {info.Name}");
    }

    
}

