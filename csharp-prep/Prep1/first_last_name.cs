using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Prep1 World!");
            Console.Write("What is your first name?");
            string name = Console.ReadLine();

            Console.Write("What is your last name?");
            string lastname = Console.ReadLine();

            Console.Write($"Your name is {lastname}, {name} {lastname}.");
        }
    }
}
