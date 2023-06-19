namespace HashTable;

    class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] words = paragraph.Split(' ');

            MyMapNode<string, int> hash = new MyMapNode<string, int>(words.Length);
            foreach (string word in words)
            {
                hash.Add(word);
            }

            Console.WriteLine("Frequency of words in the paragraph:");
            foreach (string word in words)
            {
                int frequency = hash.GetFrequency(word);
                Console.WriteLine($"{word}: {frequency}");
            }
        }
    }
}
