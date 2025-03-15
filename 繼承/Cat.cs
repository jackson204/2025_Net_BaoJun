namespace 繼承;

internal class Cat : Animal
{
    public Cat(string name):base(name)
    {
        
    }

    public new void Roar()
    {
        Console.WriteLine($"{Name} ,Meow");
    }
    public void Run()
    {
        Console.WriteLine("Run");
    }
}