using System;

// Base class
class Animal
{
    // Virtual method
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}

// Derived class 1
class Dog : Animal
{
    // Override the virtual method
    public override void MakeSound()
    {
        Console.WriteLine("HowwHoww");
    }
}

// Derived class 2
class Cat : Animal
{
    // Override the virtual method
    public override void MakeSound()
    {
        Console.WriteLine("MeowMeow");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of derived classes
        Animal dog = new Dog();
        Animal cat = new Cat();

        // Call the virtual method
        dog.MakeSound();
        cat.MakeSound();
        Console.ReadLine();
    }
}
