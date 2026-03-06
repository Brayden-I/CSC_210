// BRAYDEN IMADA

namespace HashTables;

class Program
{
    static void Main(string[] args)
    {
        // Initialize
        HashTable hashTable = new HashTable(4);

        hashTable.Insert("apple","red");
        hashTable.Insert("apple","green");

        hashTable.Insert("banana","yellow");

        hashTable.Insert("team","group");
        hashTable.Insert("meat","food");

        // Search print results
        Console.WriteLine($"apple -> {hashTable.Search("apple")}");
        Console.WriteLine($"banana -> {hashTable.Search("banana")}");
        Console.WriteLine($"team -> {hashTable.Search("team")}");
        Console.WriteLine($"meat -> {hashTable.Search("meat")}");
        
        // insert an apple entry
        hashTable.Insert("apple", "yellow");

        // Search for a non existent entry
        Console.WriteLine(hashTable.Search("non-existent"));

        // Search for an entry that exists
        Console.WriteLine(hashTable.Search("banana"));

        Console.WriteLine(hashTable.Search("team"));
        Console.WriteLine(hashTable.Search("meat"));

        // Display final table
        hashTable.DisplayTable();

    }
}
