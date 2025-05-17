namespace 擴展方法_Demo;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var number = "123";
        var numberStr = number.ParseToInt();
        Assert.Equal(123, numberStr);
    }
    [Fact]
    public void Test2()
    {
        var number = "123abc";
        Action testCode = () => number.ParseToInt();
        Assert.Throws<FormatException>(testCode);
    }
}