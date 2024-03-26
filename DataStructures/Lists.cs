using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaration and initialization of a List
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };

        // Using LINQ to perform advanced operations
        var sum = numbers.Sum();       // Calculate sum
        var average = numbers.Average();// Calculate average

        Console.WriteLine($"Sum: {sum}, Average: {average}");

        // Insert element at specific index
        numbers.Insert(2, 10);

        // Display the modified list
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
