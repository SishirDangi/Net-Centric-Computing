using System;

// Single Inheritance: Class Animal is the base class and class Dog inherits from it.
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}

// Multiple Inheritance: Classes Car and Plane inherit from the same base class Vehicle.
class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting.");
    }
}

class Car : Vehicle
{
    public void Drive()
    {
        Console.WriteLine("Car is driving.");
    }
}

class Plane : Vehicle
{
    public void Fly()
    {
        Console.WriteLine("Plane is flying.");
    }
}

// Multilevel Inheritance: Class A is the base class, class B inherits from A, and class C inherits from B.
class A
{
    public void MethodA()
    {
        Console.WriteLine("Method of class A");
    }
}

class B : A
{
    public void MethodB()
    {
        Console.WriteLine("Method of class B");
    }
}

class C : B
{
    public void MethodC()
    {
        Console.WriteLine("Method of class C");
    }
}

// Hierarchical Inheritance: Class Shape is the base class and classes Circle and Rectangle inherit from it.
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing shape.");
    }
}

class Circle : Shape
{
    public void DrawCircle()
    {
        Console.WriteLine("Drawing circle.");
    }
}

class Rectangle : Shape
{
    public void DrawRectangle()
    {
        Console.WriteLine("Drawing rectangle.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Single Inheritance
        Console.WriteLine("Single Inheritance:");
        Dog dog = new Dog();
        dog.Eat(); // Accessing method from base class
        dog.Bark(); // Accessing method from derived class

        // Multiple Inheritance
        Console.WriteLine("\nMultiple Inheritance:");
        Car car = new Car();
        car.Start(); // Accessing method from base class Vehicle
        car.Drive(); // Accessing method from derived class Car

        Plane plane = new Plane();
        plane.Start(); // Accessing method from base class Vehicle
        plane.Fly(); // Accessing method from derived class Plane

        // Multilevel Inheritance
        Console.WriteLine("\nMultilevel Inheritance:");
        C objC = new C();
        objC.MethodA(); // Accessing method from class A
        objC.MethodB(); // Accessing method from class B
        objC.MethodC(); // Accessing method from class C

        // Hierarchical Inheritance
        Console.WriteLine("\nHierarchical Inheritance:");
        Circle circle = new Circle();
        circle.Draw(); // Accessing method from base class Shape
        circle.DrawCircle(); // Accessing method from derived class Circle

        Rectangle rectangle = new Rectangle();
        rectangle.Draw(); // Accessing method from base class Shape
        rectangle.DrawRectangle(); // Accessing method from derived class Rectangle
        Console.ReadLine();
    }
}
