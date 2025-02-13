using FluentAssertions;

namespace String_Demo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var msg = "Cahina";
        msg = "China";
        msg.Should().Be("China");
    }

    [Fact]
    public void Test2()
    {
        var a = "Hello";
        var b = "World";
        var c = a + b;
        var result = c == "HelloWorld";
        result.Should().BeTrue();
    }

    
}
