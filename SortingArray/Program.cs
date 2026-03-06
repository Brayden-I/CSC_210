// BRAYDEN IMADA
using SortingArrays;

namespace SortingArray;

class Program
{
    static void Main(string[] args)
    {
        WorkingWithArrays workingWithArrays = new WorkingWithArrays(); // This will create the object and construct the random data inside the array

        workingWithArrays.printArray(); // eeeewwww

        workingWithArrays.insertAnIntegar(67, 67);

        workingWithArrays.printArray(); // eeeewwww but 67

        workingWithArrays.BubbleSort();

        workingWithArrays.printSortedArray(); // Now it's pretty
    }
}
