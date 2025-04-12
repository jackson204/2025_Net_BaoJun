namespace Abstract_Demo;

public class Dog : Animal
{
    public override void Run()
    {
        Console.WriteLine("Dog is running");
    }

    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}
