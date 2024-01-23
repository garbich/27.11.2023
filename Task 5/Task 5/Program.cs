namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("input world with a space");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            list.AddRange(words);


            list.RemoveAll(list => list.Length > 3);
            Console.WriteLine("Count of element: " + list.Count);
            foreach (string word in list)
            {
                Console.WriteLine(word);
            }
        }
    }
}