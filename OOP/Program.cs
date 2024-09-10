/**
class Car
{
    // Define Attributes
    public string Brand;
    public string Model;
    public int Year;


    // Method to display car details
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }

    // Constructor to initialize fields
}

// class to call and make use of the created class
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();

        // Assignin values to object fields
        myCar.Brand = "Toyota";
        myCar.Model = "Camry";
        myCar.Year = 2020;

        // Calling a method on the object
        myCar.DisplayCarInfo();
    }
}
*/

/**
// USing Constructors

class Car
{
    // Define Attributes;
    public string Brand;
    public string Model;
    public int Year;

    // constructor to initiate fields when an instance is planned to be created
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    // define a method for car
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}

// program to utilize class with the main entry point
class Program
{
    // Main entry point
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022);
        myCar.DisplayCarInfo();
        
    }
}
*/

// ENCAPSULATION CONCEPT
/** Encapsulation is about controlling access to class members (fields and methods).
 * This is achieved using access modifiers like private, public, and protected.
class Car(string brand, string model, int year)
{

    // getter method to get car details
    public void DisplayCarInfo()
    {
        Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}");
    }

    // setter method to set or modify the year attribute
    public void UpdateYear(int newYear)
    {
        year = newYear;
    }
}


// program to utilize class with the main entry point
class Program
{
    // Main entry point
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Camry", 2022);
        myCar.DisplayCarInfo();

        //update car year
        myCar.UpdateYear(2024);

        // view new car info
        myCar.DisplayCarInfo();

    }
}
*/

/**

// INHERITANCE CONCEPT

class Vehicle
{
    public int Speed;
    public string? Color;

    public void DisplayInfo()
    {
        Console.WriteLine($"Speed: {Speed}, Color: {Color}");
    }
}

// Child class inheriting from vehicle
class Car : Vehicle
{
    public string? Brand;

    public void DisplayCarDetails()
    {
        Console.WriteLine ($"Brand: {Brand}, Speed: {Speed}, Color: {Color}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Craeting an object of the child class
        Car myCar = new Car
        {
            Brand = "BMW",
            Speed = 120,
            Color = "Red"
        };

        // Accessing method from parent class
        myCar.DisplayInfo();

        // Accessing method from child class
        myCar.DisplayCarDetails();
    }
}
*/

/**

// POLYMORPHISM CONCEPT
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Derived class
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("The dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal(); // Base class object
        Animal myDog = new Dog();
        Dog someDog = new Dog();

        myAnimal.Sound(); // Outputs: the animal makes a sound
        myDog.Sound(); // Outptus the Dog barks
        someDog.Sound(); // outputs the dog barks
    }
}
*/

/** Abstraction Concept:
 * Abstraction hides the complex implementation details of a class and shows only the essential features.
In C#, you can achieve abstraction using abstract classes and interfaces.

// ABSTRACT CLASS
abstract class Shape
{
    public abstract void Draw(); // Abstract method (no implementation)
}

// Derived class providing the implementation of Draw()
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawin a circle...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape myShape = new Circle(); // Abstract class reference, derived class object
        myShape.Draw(); // Outputs: Drawing a circle
    }
}
*/

// INTERFACE CONCEPT:
/** An interface defines a contract that classes must follow.
 * A class can implement multiple interfaces, which enables a form of multiple inheritance.
 **/

interface IAnimal
{
    void Speak(); // Method signature (no implementation)
}