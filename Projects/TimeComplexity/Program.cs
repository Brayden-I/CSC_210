//BRAYDEN IMADA
//DATA STRUCTURE
//2/5/26

namespace TimeComplexity;

class Program
{
    // INITIAL VARIABLES
    private const int ARRAY_SIZE = 1000;

    static void Main(string[] args)
    {
        AsymptoticAnalysis analysis = new AsymptoticAnalysis();

        int[] numbers = CreateArray();

        analysis.array = numbers;

        Console.WriteLine($"Array size: {analysis.array.Length}\n");

        // Test Constant time 0(1)
        int constantSteps = analysis.Constant();
        Console.WriteLine($"Steps taken: {constantSteps}\n");

        // Logarithmic 0(log n)
        int logIterations = analysis.Logarithm();
        Console.WriteLine($"Iterations: {logIterations}\n");

        // Linear 0(n)
        int linearSteps = analysis.Linear();
        Console.WriteLine($"Steps taken: {linearSteps}\n");

        // Quadratic 0(n^2)
        int quadraticIterations = analysis.Quadratic();
        Console.WriteLine($"Iterations: {quadraticIterations}\n");

        // Summary
        Console.WriteLine($"Constant O(1):        {constantSteps} steps");
        Console.WriteLine($"Logarithmic O(log n): {logIterations} iterations");
        Console.WriteLine($"Linear O(n):          {linearSteps} steps");
        Console.WriteLine($"Quadratic O(n^2):      {quadraticIterations} iterations");
    }

    static int[] CreateArray()
    {
        int[] array = new int[ARRAY_SIZE];
        for (int i = 0; i < ARRAY_SIZE; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
}
