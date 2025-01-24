using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int usernumberconverted = -1;
        while (usernumberconverted!= 0)
        {
            Console.Write("Enter any number and 0 to quit: ");
            
            string usernumber = Console.ReadLine();
            usernumberconverted = int.Parse(usernumber);
            
            
            if (usernumberconverted!= 0)
            {
                numbers.Add(usernumberconverted);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }
        }   
        Console.WriteLine($"The max is: {max}");


    }
}