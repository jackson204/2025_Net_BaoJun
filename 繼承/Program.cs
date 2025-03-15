namespace 繼承;

class Program
{
    private static void Main(string[] args)
    {
        Cat cat = new Cat("Kitty");
    
        cat.Roar();
        Dog dog = new Dog();
        dog.Name = "Doggy";
        dog.Roar();
        Animal animal = new Animal();
        animal.Name = "Animal";
        animal.Roar();
    }
}