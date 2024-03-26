using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaration and initialization of a Dictionary
        Dictionary<string, int> scores = new Dictionary<string, int>();

        // Adding key-value pairs to the dictionary
        scores["John"] = 90;
        scores["Alice"] = 85;
        scores["Bob"] = 95;

        // Iterating over key-value pairs in the dictionary
        foreach (var kvp in scores)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }

        // Accessing value by key
        int score = scores["Alice"];
        Console.WriteLine("Alice's Score: " + score);
    }
}
