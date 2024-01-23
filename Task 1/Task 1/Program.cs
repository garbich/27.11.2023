namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 3, 8, 4, 5 };

           foreach (int i in arr)
           {
                Console.Write(i + " ");
           }
            int max = 0;
            int min = int.MaxValue;

            foreach(int i in arr)
            {
                if(i > max)
                {
                    max = i;
                }
                if(i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine($"\nMin - {min} Max - {max}");
        }
    }
}