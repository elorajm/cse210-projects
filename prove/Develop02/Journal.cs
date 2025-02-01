using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private int consecutiveDays;

    public Journal()
    {
        entries = new List<Entry>();
        consecutiveDays = 0;
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
        consecutiveDays++;
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public double GetAverageEntriesPerWeek()
    {
        if (entries.Count == 0)
            return 0;

        TimeSpan totalTimeSpan = DateTime.Now - DateTime.Parse(entries[0].Date);
        double totalDays = totalTimeSpan.TotalDays;

        // Ensure there's at least 1 week if the journal is less than a week old
        double totalWeeks = totalDays / 7;
        if (totalWeeks < 1)
            totalWeeks = 1; // At least 1 week if the duration is less than a week

        return entries.Count / totalWeeks;
    }

    public int GetConsecutiveDays()
    {
        return consecutiveDays;
    }

    public void ResetConsecutiveDays()
    {
        consecutiveDays = 0;
    }

    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Prompt}|{entry.Response}|{entry.Date}");
            }
        }
    }

    public void LoadFromFile(string filePath)
    {
        entries.Clear(); 
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    Entry entry = new Entry
                    {
                        Prompt = parts[0],
                        Response = parts[1],
                        Date = parts[2]
                    };
                    entries.Add(entry);
                }
            }
        }
    }
}
