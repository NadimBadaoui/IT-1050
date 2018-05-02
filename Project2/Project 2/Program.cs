
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.AskUserForNameAndAge();
            person1.CreateSpouseIfMarried();

            Person person2 = new Person();
            person2.AskUserForNameAndAge();
            person2.CreateSpouseIfMarried();

            System.Console.WriteLine("Average Age: " + Person.AverageAge());
            System.Console.ReadKey();
        }
    }
}
