using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Declaration and initialization of a HashSet
        HashSet<int> set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> set2 = new HashSet<int>() { 4, 5, 6, 7, 8 };

        // Union of two sets
        HashSet<int> unionSet = new HashSet<int>(set1);
        unionSet.UnionWith(set2);

        // Intersection of two sets
        HashSet<int> intersectionSet = new HashSet<int>(set1);
        intersectionSet.IntersectWith(set2);

        // Displaying the results
        Console.WriteLine("Union:");
        foreach (int num in unionSet)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine("\nIntersection:");
        foreach (int num in intersectionSet)
        {
            Console.Write(num + " ");
        }
    }
}
