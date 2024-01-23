namespace MySpace
{
    class Program
    {

        public static void Main(string[] args)
        {
            Person person = new Person("Artyr", 17);
           
            Console.WriteLine(person.Name + " " + person.Age);

            person.Age = 16;

            Console.WriteLine(person.Age);
        }
    }
}