// See https://aka.ms/new-console-template for more information
using Static_Single;

var myClass1 = new MyClass();
var myClass2 = new MyClass();
MyDbContext.Instance.UserName = "Admin";

namespace Static_Single
{
    public class MyClass
    {
        static MyClass()
        {
            Console.WriteLine("MyClass static constructor");
        }

        public MyClass()
        {
            Console.WriteLine("MyClass constructors");
        }
    }
}
