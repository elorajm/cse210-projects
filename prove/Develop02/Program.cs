
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();

        while (true)
        {
            Console.WriteLine("Welcome to your daily journal! Please pick from the options below:");
            Console.WriteLine("1. Write a new Journal entry.");
            Console.WriteLine("2. Show your Journal in all its glory.");
            Console.WriteLine("3. Save your journal entries to files.");
            Console.WriteLine("4. Load your journal entries for a specific date.");
            Console.WriteLine("5. Quit but not before you write your journal entry for the day.");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry
                    {
                        Prompt = randomPrompt,
                        Response = response,
                        Date = DateTime.Now.ToString() 
                    };
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved.");
                    break;
                case "2":
                    DisplayJournal(journal);
                    break;
                case "3":
                    Console.Write("Enter file name to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.Write("Enter the date (MM/DD/YYYY) to load entries for: ");
                    string dateToLoad = Console.ReadLine();
                    DisplayEntriesForDate(journal, dateToLoad);
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    DisplayStats(journal);
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayJournal(Journal journal)
    {
        List<Entry> entries = journal.GetEntries();
        if (entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            Console.WriteLine("Journal Entries:");
            foreach (Entry entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
            }
        }
    }

    static void DisplayEntriesForDate(Journal journal, string dateToLoad)
    {
        List<Entry> entries = journal.GetEntries();
        bool foundEntries = false;

        Console.WriteLine($"Entries for {dateToLoad}:");
        foreach (Entry entry in entries)
        {
            if (entry.Date.StartsWith(dateToLoad))
            {
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}");
                Console.WriteLine();
                foundEntries = true;
            }
        }

        if (!foundEntries)
        {
            Console.WriteLine("No entries found for the specified date.");
        }
    }

    static void DisplayStats(Journal journal)
    {
        double averageEntriesPerWeek = journal.GetAverageEntriesPerWeek();
        int currentStreak = journal.GetConsecutiveDays();

        Console.WriteLine($"Average entries per week: {averageEntriesPerWeek:F2}");
        Console.WriteLine($"Current streak: {currentStreak} days");
    }
}
