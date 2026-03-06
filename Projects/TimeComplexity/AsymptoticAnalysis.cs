//BRAYDEN IMADA
//DATA STRUCTURE
//2/5/26

using System;

namespace TimeComplexity;

public class AsymptoticAnalysis
{
    public int[] array;

    // Constant O(1) - Access single element regardless of array size
    public int Constant()
    {
        int steps = 0;
        
        int firstElement = array[0]; // Only one operation
        steps++; 
        
        Console.WriteLine($"Constant O(1) - Accessed first element: {firstElement}");
        
        return steps;
    }

    // Logarithmic O(log n) - Binary search approach
    public int Logarithm()
    {
        int iterations = 0;
        int low = 0;
        int high = array.Length - 1;
        
        // Simulate binary search - dividing the problem space in half each time
        while (low <= high)
        {
            iterations++;
            int mid = low + (high - low) / 2;
        
            low = mid + 1; // Move to upper half to continue the pattern
        }
        
        Console.WriteLine($"Logarithmic O(log n) - Completed {iterations} iterations");
        
        return iterations;
    }

    // Linear O(n) - Display all elements and count operations
    public int Linear()
    {
        int steps = 0;
        
        Console.WriteLine("Linear O(n) - Displaying all elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
            steps++; // Count each iteration
        }
        Console.WriteLine("\n");
        
        return steps;
    }

    // Quadratic - Nested loop through array
    public int Quadratic()
    {
        int iterations = 0;
        
        // Nested loops create n * n iterations
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                iterations++;
            }
        }
        
        Console.WriteLine($"Total iterations: {iterations}\n");
        
        return iterations;
    }
}