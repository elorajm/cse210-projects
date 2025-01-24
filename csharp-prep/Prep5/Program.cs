using System;

class Program
{
    static void Main(string[] args)
    {
        initialmessage();
        string fuctionname = username();
        int functionnumber = favoritenumber();
        int funtionsquare = squarenumber(functionnumber);
        result(fuctionname, funtionsquare);



        static void initialmessage()
        {
            Console.WriteLine("Welcome to the program");
        }

         static string username()
        {
            Console.Write("Please enter your name: ");
            string nameoftheuser = Console.ReadLine();
            return nameoftheuser;
        }

        static int favoritenumber()
        {
            Console.Write("Please enter your favorite number: ");
            string numberoftheuser = Console.ReadLine();
            int numberoftheuserconverted = int.Parse(numberoftheuser);
            return numberoftheuserconverted;
        }

        static int squarenumber(int numberoftheuserconverted)
        {
            int squareofthenumber = numberoftheuserconverted*numberoftheuserconverted;
            return squareofthenumber;
        }

        static void result(string nameoftheuser, int squareofthenumber )
        {
            Console.WriteLine($"{nameoftheuser}, the square of your number is {squareofthenumber}");
            
        }

    }
}