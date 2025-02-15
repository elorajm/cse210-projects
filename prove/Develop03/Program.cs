using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Reference ref1 = new Reference("Hebrews", 11, 1);
        Scripture scripture1 = new Scripture("Now faith is the substance of things hoped for, the evidence of things not seen.", ref1);

        Reference ref2 = new Reference("Ether", 12, 12);
        Scripture scripture2 = new Scripture("For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith.", ref2);

        List<Scripture> scriptures = new List<Scripture> { scripture1, scripture2 };

        while (true)
        {
            Console.WriteLine("Please choose a scripture to practice:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].Ref}");
            }
            Console.WriteLine("Enter the number for the scripture or 'q' to quit:");

            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= scriptures.Count)
            {
                Scripture selectedScripture = scriptures[choice - 1];
                PracticeScripture(selectedScripture);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    public static void PracticeScripture(Scripture scripture)
    {
        string currentText = scripture.Text;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Ref);
            Console.WriteLine(currentText);
            Console.WriteLine("\nPress Enter to hide 2 more words or 'q' to quit practicing.");

            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            currentText = WordHider.HideWords(currentText, 2);
        }
    }
}