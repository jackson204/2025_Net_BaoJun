namespace 繼承;

internal class Program
{
    private static void Main(string[] args)
    {
        var cat = new Cat("Kitty");

        cat.Roar();
        var dog = new Dog();
        dog.Name = "Doggy";
        dog.Roar();
        var animal = new Animal();
        animal.Name = "Animal";
        animal.Roar();
    }
}
