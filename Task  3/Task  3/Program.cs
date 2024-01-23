namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {

         string num = Console.ReadLine();

            char[] arr = num.ToCharArray();

            Array.Reverse(arr);
            Console.WriteLine(arr);  

        }
    }
}