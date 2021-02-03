using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Hi,  {firstName} {lastName}");
        }
    }
}
