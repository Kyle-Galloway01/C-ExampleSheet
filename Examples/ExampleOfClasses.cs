using System;

// Define a class named Person
public class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                Console.WriteLine("Age cannot be negative.");
        }
    }

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display information about the person
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Person class
        Person person1 = new Person("John", 30);

        // Access and modify properties
        person1.Name = "Alice";
        person1.Age = 25;

        // Display information using a method
        person1.DisplayInfo();
    }
}
