using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaration and initialization of a Queue
        Queue<string> queue = new Queue<string>();

        // Enqueue elements into the queue
        queue.Enqueue("John");
        queue.Enqueue("Alice");
        queue.Enqueue("Bob");

        // Dequeue elements from the queue
        string dequeuedElement = queue.Dequeue();
        Console.WriteLine("Dequeued Element: " + dequeuedElement);

        // Peek at the front element of the queue
        string frontElement = queue.Peek();
        Console.WriteLine("Front Element: " + frontElement);
    }
}
