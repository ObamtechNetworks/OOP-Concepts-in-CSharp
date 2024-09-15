



// ENCAPSULATION CONCEPT








// INTERFACE CONCEPT:






// -> Define class program
/*
class Program
{
    // function to take input from the user
    public static string userInput()
    {
        string input = Console.ReadLine();
        return input;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter any number to divide 100 by number");
        string input = userInput();
        
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("You didn't Enter a value!");
            return;
        }

        // extend program

        try
        {
            float convertInput = float.Parse(input);
            float divide100By = 100 / convertInput;
            Console.WriteLine($"Your result is: 100 / {input} ==> {divide100By}");
        }
        catch (Exception ext)
        {
            if (ext is FormatException)
            {
                Console.WriteLine($"Error: Value must be a number");
            }

            if (ext is DivideByZeroException)
            {
                Console.WriteLine($"Error: Cannot Divide by Zero {ext.Message}");
            }

            if (ext is NullReferenceException)
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
*/

using System.Linq.Expressions;

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
*//**
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
*//** Encapsulation is about controlling access to class members (fields and methods).
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
*//**

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
*//**

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
*//** Abstraction Concept:
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
*//** An interface defines a contract that classes must follow.
 * A class can implement multiple interfaces, which enables a form of multiple inheritance.


interface IAnimal
{
    void Speak(); // Method signature (no implementation)
}

// Class implementing the interface
class Cat : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("The cat meows");
    }
}

// Program entry point
class Program
{
    static void Main(string[] args)
    {
        IAnimal myCat = new Cat();
        myCat.Speak(); // Outputs: The cat meows
    }
}
*//**
//EXCEPTION HANDLING
class Program
{

    static void Main(string[] args)
    {
		try
		{
			int num1 = 10;
			int num2 = 0;
			int result = num1 / num2;
			Console.WriteLine(result);
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Exception Message: {ex.Message}");
		}
		finally
		{
            Console.WriteLine("This block always executes, whether an exception occurred or not");

        }
    }
}
*//** HANDS DateOnly EXERCISE: Exception HANDLING
 * 
 * 
 * Write a program that takes a number from the user and divides 100 by that number.
 * Handle cases where the user inputs zero (division by zero error) and handle cases
 * where the user inputs a non-integer value (formatting error).
--------------------------------------------------------------------------------------
Extend the above program to define and throw a custom exception if the number entered
is greater than 100, with a message "Number too large for this operation."
 * **/

// extend program ===> custom Exception
public class CustomException : Exception
{
    public CustomException() 
    {

    }
    public CustomException(string message) : base(message)
    {

    }
}

class Program
{
    // function to take input from the user
    public static string userInput()
    {
        string input = Console.ReadLine();
        return input;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter any number to divide 100 by number");
        string input = userInput();

        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("You didn't Enter a value!");
            return;
        }


        try
        {

            // extend program
            if (float.TryParse(input, out float convertInput))
            {
                if (convertInput > 100)
                {
                    throw new CustomException("Your value is too large!");
                }
                else if (convertInput == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero");
                }

                // perform division
                float divide100By = 100 / convertInput;
                Console.WriteLine($"Your result is: 100 / {input} ==> {divide100By}");
            }

            else
            {
                Console.WriteLine($"Error: Value must be a number");
                return;
            }
        }
        catch (CustomException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Program finished. Thank you for using the program.");
        }
    }
}
