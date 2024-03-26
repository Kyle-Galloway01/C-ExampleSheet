using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaration and initialization of a Stack
        Stack<int> stack = new Stack<int>();

        // Push elements onto the stack
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Pop elements from the stack
        int poppedElement = stack.Pop();
        Console.WriteLine("Popped Element: " + poppedElement);

        // Peek at the top element of the stack
        int topElement = stack.Peek();
        Console.WriteLine("Top Element: " + topElement);
    }
}
