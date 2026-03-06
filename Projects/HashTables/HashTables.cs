// BRAYDEN IMADA

namespace HashTables;

public class HashTable
{
    // FIELDS
    private List<(string key, string value)>[] table; // Create an array of bucket lists that hold Key-Value tuples
    private int size;

    // CONSTRUCTOR
    public HashTable(int size)
    {
        this.size = size;
        table = new List<(string key, string value)>[size];

        for (int i = 0; i < size; i++)
        {
            table[i] = new List<(string key, string value)>(); // Place a bucket list in every cell
        }
    }
    
    // METHODS
    public int Hash(string Key)
    {
        int sumAscii = 0;

        foreach (char c in Key)
        {
            sumAscii += Convert.ToInt32(c); // Get ASCII value
        }

        return sumAscii % size;
    }

    public void Insert(string key, string Value)
    {
        int index = Hash(key);

        table[index].Add((key, Value));
    }

    public string Search(string key)
    {
        int index = Hash(key);

        foreach (var pair in table[index]) // Lets find that pair in the bucket
        {
            if (pair.key == key) // if the pair jey equals the correct key then good 
            {
                return pair.value;
            }
        }

        return "-1"; // Not found
    }

    // print

    public void DisplayTable()
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write($"[{i}] -> "); // Show what bucket
            if (table[i].Count == 0)
            {
                Console.WriteLine("(Empty)");
            }
            else
            {
                Console.Write("[");
                foreach (var pair in table[i]) // for every item in the current bucket
                {
                    Console.Write($"({pair.key} = {pair.value})");
                }
                Console.Write("]");
            }
            Console.WriteLine();
        }
    }
}
