using System;
using System.Numerics;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomgenerator = new Random();
        int randomnumber = randomgenerator.Next(1, 100);
        Console.WriteLine(randomnumber);

        Console.WriteLine("Welcome to the Random Game!!");
        Console.WriteLine("You will need to guess a number");
        Console.WriteLine("Ready? Go!!");

        Console.Write("What is the magic number? ");
        string userguessednumber = Console.ReadLine();
        int userguessednumberconverted = int.Parse(userguessednumber);
        
        while(userguessednumberconverted<randomnumber || userguessednumberconverted>randomnumber)
        {
             
            
            if (userguessednumberconverted<randomnumber)
            {
                Console.WriteLine("Higher");
                Console.Write("What is the magic number? ");
                userguessednumber = Console.ReadLine();
                userguessednumberconverted = int.Parse(userguessednumber);
            }
            else if (userguessednumberconverted>randomnumber)
            {
                Console.WriteLine("Lower");
                Console.Write("What is the magic number? ");
                userguessednumber = Console.ReadLine();
                userguessednumberconverted = int.Parse(userguessednumber);
            }
        }
        if (userguessednumberconverted==randomnumber)
            {
                Console.WriteLine("Well done!! You guessed it !!");
            }
     
    }
}
