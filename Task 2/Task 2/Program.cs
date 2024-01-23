namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

           
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Input num: ");
                int num = Int32.Parse(Console.ReadLine());
                list.Add(num);
            }

            int sum = 0;

            foreach(int i in list)
            {
               sum += i;
            }
            Console.WriteLine("Sum: " + sum);

            int max = 0;
            int min = int.MaxValue;

            foreach (int i in list)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }

            Console.WriteLine($"Max - {max}");
            Console.WriteLine($"Min - {min}");

            int multiplication = 1;

            foreach (int i in list)
            {
                multiplication *= i;
            }
            Console.WriteLine("Mulptiplication: " + multiplication);
        }
    }
}