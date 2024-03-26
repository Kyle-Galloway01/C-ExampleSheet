using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Example of basic C# programming concepts
        Console.WriteLine("Hello, world!"); // Output: Hello, world!

        // Variables and data types
        int age = 30;
        double height = 6.2;
        string name = "John";

        // Conditional statements
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        // Loops
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }

        // Arrays
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum of numbers: " + numbers.Sum()); // Output: Sum of numbers: 15

        // Lists
        List<string> names = new List<string>() { "Alice", "Bob", "Charlie" };
        names.Add("David");
        Console.WriteLine("Number of names: " + names.Count); // Output: Number of names: 4

        // Stacks
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        int poppedElement = stack.Pop();
        Console.WriteLine("Popped Element: " + poppedElement); // Output: Popped Element: 2

        // Queues
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("John");
        queue.Enqueue("Alice");
        string dequeuedElement = queue.Dequeue();
        Console.WriteLine("Dequeued Element: " + dequeuedElement); // Output: Dequeued Element: John

        // Dictionaries
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores["John"] = 90;
        scores["Alice"] = 85;
        Console.WriteLine("John's score: " + scores["John"]); // Output: John's score: 90

        // Sets
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
        set1.UnionWith(set2);
        Console.WriteLine("Union of sets: " + string.Join(", ", set1)); // Output: Union of sets: 1, 2, 3, 4, 5, 6, 7, 8

        // Linked Lists
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(1);
        linkedList.AddLast(2);
        linkedList.AddLast(3);
        Console.WriteLine("Linked List elements:");
        foreach (int num in linkedList)
        {
            Console.WriteLine(num);
        }
    }
}
