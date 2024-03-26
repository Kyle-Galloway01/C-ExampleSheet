using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

// Base class demonstrating encapsulation, inheritance, and polymorphism
public class Animal
{
    private string name;
    protected int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }

    public override string ToString()
    {
        return $"{name} is {age} years old";
    }
}

// Derived class demonstrating inheritance and polymorphism
public class Dog : Animal
{
    public Dog(string name, int age) : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static async Task Main()
    {
        // Access modifiers and control flow
        Dog dog = new Dog("Buddy", 5);
        Console.WriteLine(dog); // Output: Buddy is 5 years old
        dog.MakeSound(); // Output: Dog barks

        // LINQ for querying collections
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers)); // Output: Even Numbers: 2, 4

        // Asynchronous programming with async and await
        await Task.Delay(1000); // Simulate asynchronous operation
        Console.WriteLine("Asynchronous operation completed");

        // Serialization and deserialization using JSON
        var jsonString = JsonConvert.SerializeObject(dog);
        Console.WriteLine("Serialized JSON: " + jsonString); // Output: Serialized JSON: {"name":"Buddy","age":5}
        var deserializedDog = JsonConvert.DeserializeObject<Dog>(jsonString);
        Console.WriteLine("Deserialized Dog: " + deserializedDog); // Output: Deserialized Dog: Buddy is 5 years old
    }
}
