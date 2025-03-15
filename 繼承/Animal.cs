namespace 繼承;

internal class Animal
{
    public string Name { get;set; }

    public Animal()
    {
        
    }
    protected Animal(string name)
    {
        Name = name;
    }
    public int Age { get; set; }

    public string Color { get; set; }

    public void Roar()
    {
        Console.WriteLine($"{Name} ,Roar");
    }
}
