using System;

class Program
{
    static void Main()
    {
        // Declaration and initialization of an array
        int[] numbers = { 1, 2, 3, 4, 5 };

        // Using foreach loop to iterate over the array
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Using Array class methods
        Array.Reverse(numbers); // Reverse the array
        Array.Sort(numbers);    // Sort the array

        // Display the modified array
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
