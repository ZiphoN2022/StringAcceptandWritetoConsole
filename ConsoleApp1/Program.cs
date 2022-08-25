using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstName = string.Empty;
            string lastName = string.Empty;
            string course = string.Empty;

            Console.WriteLine("What is your name ?");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your LastName?");
            lastName = Console.ReadLine();

            Console.WriteLine("What is your Course");
            course = Console.ReadLine();

            Console.WriteLine("Welcome to your course "+course.PadRight(10) +firstName.PadRight(5) +lastName.PadRight(5));
        }
    }
}
