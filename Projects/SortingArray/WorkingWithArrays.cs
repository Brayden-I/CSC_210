// BRAYDEN IMADA
using System;

namespace SortingArrays;

public class WorkingWithArrays
{
    Random random = new Random();

    // FIELDS
    private int[] data = new int[100]; // Integar array that holds the working set
    private int[] sorted = new int[100]; // Integar array that holds a sorted copy

    // CONSTRUCTOR
    public WorkingWithArrays()
    {
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = random.Next(0,999);
        }
    }

    // METHODS

    // Sort
    public void BubbleSort()
    {
        int temp;
        int[] array = data;

        for (int j = 0; j <= array.Length; j++) 
        {
            for (int i = 0; i <= array.Length - 2; i++)
            {
                // Swap logic
                if (array[i] > array[i + 1])
                {
                    temp = array[i + 1];
                    array[i + 1] = array[i];
                    array[i] = temp;

                    Console.WriteLine($"AT {j + 1} passes, {i + 1} Comparisons: swapped {array[i]} and {array[i + 1]}");
                }
            }
        }

        sorted = array;
    }

    public void insertAnIntegar(int NewValue, int Position)
    {
        int[] enlarged = new int[data.Length + 1];

        for (int i = 0; i < Position; i++)
        {
            enlarged[i] = data[i];
        }

        enlarged[Position] = NewValue;

        for (int i = Position; i < data.Length; i++)
        {
            enlarged[i + 1] = data[i];
        }

        data = enlarged;
    }

    // Print
    public void printArray()
    {
        Console.WriteLine("Printing unsorted array");
        for (int i = 0; i < data.Length; i++)
        {
            Console.WriteLine($"{i}: {data[i]}");
        }
    }

    public void printSortedArray()
    {
        Console.WriteLine("Printing sorted array");
        for (int i = 0; i < sorted.Length; i++)
        {
            Console.WriteLine($"{i}: {sorted[i]}");
        }
    }
}
