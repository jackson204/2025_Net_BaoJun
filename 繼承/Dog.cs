namespace 繼承;

internal class Dog : Animal
{
    public new void Roar()
    {
        Console.WriteLine($"{Name} ,Bark");
    }
}
