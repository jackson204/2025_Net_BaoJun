using System.Xml;
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

    [Fact]
    public void Test3()
    {
        string a = default;
        a.Should().Be(null);
    }

    [Fact]
    public void Test4()
    {
        string? a = default;
        a.Should().Be(null);
    }

    [Fact]
    public void Test5()
    {
        int? a = default;
        int b = default;
        a.Should().Be(null);
        b.Should().Be(0);
    }

    [Fact]
    public void Test6()
    {
        int a = 1;
        int? b = null;
        (a - b).Should().Be(null);

    }

    [Fact]
    public void Test7()
    {
        DateTime a = new DateTime(2021, 1, 1);
        DateTime b = default;
        DateTime? c = null;
        a.Should().Be(new DateTime(2021, 1, 1));
        b.Should().Be(new DateTime(0001, 01, 01));
        c.Should().Be(null);
    }
}
