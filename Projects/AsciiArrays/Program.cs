namespace AsciiArrays;

class Program
{
    public static int HashFunction(string String, int ArrayLength) // Gets the sum of ascii from a string
    {
        int sum = 0;
        char[] charArray = String.ToCharArray(); // Get the char array from string

        foreach (char c in charArray)
        {
            sum += Convert.ToInt32(c); // Converting to Int returns the char's ASCII
        }

        return sum % ArrayLength; // Return result
    }

    static void Main(string[] args)
    {
        // Create our key value pair array
        string[][] MultiDimArray = new string[][]
        {
            // An array
            ["apple", "red"], // with arrays inside
            ["banana", "yellow"],
            ["plum", "purple"]
        };

        foreach (string[] subArray in MultiDimArray) // Loop through each array in the multi-dimensional array
        {
            string key = subArray[0]; // The key is the first element
            int hashIndex = HashFunction(key, MultiDimArray.Length);
            Console.WriteLine($"Key: '{key}' -> Hash Index: {hashIndex}");
        }
    }
}
