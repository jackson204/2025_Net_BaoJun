namespace 多態_Demo;

class Program
{
    private static void Main(string[] args)
    { 
        Animal animal = new Dog();
        if (animal is Dog dog)
        {
           dog.Bark(); 
        }
    }
}