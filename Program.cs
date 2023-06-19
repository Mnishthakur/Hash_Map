namespace HashTable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hash table");

        MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
        hash.Add("0", "To");
        hash.Add("1", "Be");
        hash.Add("2", "or");
        hash.Add("3", "not");
        hash.Add("4", "to");
        hash.Add("5", "be");

        string hash5 = hash.Get("5");
        Console.WriteLine("5th Index value;" + hash5);

        string hash2 = hash.Get("2");
        Console.WriteLine("2th index value:" + hash2);

    }
}
