using System;
using System.Collections.Generic;

// Main program class to demonstrate the Activity tracking system.
public class Program
{
    // Entry point of the application.
    public static void Main()
    {
        // --- Create Activity Objects ---
        // Instantiate different types of activities with  dates.
        // Using DateTime.Now.Date to get today's date without the time component.
        // AddDays() is used to set dates relative to today.

        // Example: An activity from 2 days ago
        Activity running = new Running(DateTime.Now.Date.AddDays(-2), 30, 4.8); // 4.8 km run in 30 mins

        // Example: An activity from yesterday
        Activity cycling = new Cycling(DateTime.Now.Date.AddDays(-1), 45, 25.0); // 45 mins cycling at 25.0 kph

        // Example: An activity from today
        Activity swimming = new Swimming(DateTime.Now.Date, 60, 40); // 60 mins swimming, 40 laps

        // --- Store Activities in a List ---
        // Create a list that can hold objects of type Activity.
        // This list can contain instances of any class derived from Activity (Running, Cycling, Swimming).
        // This demonstrates polymorphism.
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        Console.WriteLine("--- Activity Summaries ---");

        // --- Iterate and Display Activity Summaries ---
        // Loop through each activity in the list.
        foreach (var activity in activities)
        {
            // Call the GetSummary() method for each activity.
            // Due to polymorphism, the correct overridden version of GetSummary()
            // (from Running, Cycling, or Swimming class) will be executed based on
            // the actual type of the object stored in the 'activity' variable.
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine(); // Add a blank line for better readability between summaries
        }
    }
}