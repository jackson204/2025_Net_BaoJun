// See https://aka.ms/new-console-template for more information
var myClass1 = new MyClass();
var myClass2= new MyClass();
MyDbContext.Instance.UserName = "Admin";

public class MyClass
{
    public MyClass()
    {
        Console.WriteLine("MyClass constructors");
    }
    static MyClass()
    {
        Console.WriteLine("MyClass static constructor");
    }
}