namespace 繼承;

internal class Animal
{
    public Animal()
    {
    }

    protected Animal(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public string Color { get; set; }

    public void Roar()
    {
        Console.WriteLine($"{Name} ,Roar");
    }
}
