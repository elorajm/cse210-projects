using System;
using System.Collections.Generic; // Import the namespace for List

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Video objects.
        List<Video> videos = new List<Video>{
            new Video("C# Tutorial for Beginners", "John Doe", 3600), 
            new Video("Advanced C# Concepts", "Jane Smith", 5400), 
            new Video("C# Best Practices", "Peter Jones", 2700), 
            new Video("Building a C# Application", "Alice Brown", 7200)  
        };

        // Iterate through the videos and display them.
        for (int i = 0; i < videos.Count; i++)
        {
            Console.WriteLine($"Video #{i + 1}:");  //Number the videos
            videos[i].display();
            Console.WriteLine(new String('-', 30)); // Separator line
        }

        // Asking if someon wants to add a comment.
        Console.Write("Do you want to add a comment to any of the videos? (y/n): ");
        string addCommentResponse = Console.ReadLine().ToLower();

        while (addCommentResponse == "y") // Loop for multiple comments
        {
            // Prompt to select a video.
            Console.Write("Enter the number of the video you want to comment on: ");
            if (int.TryParse(Console.ReadLine(), out int videoIndex) && videoIndex > 0 && videoIndex <= videos.Count)
            {
                // Get the video
                Video selectedVideo = videos[videoIndex - 1];

                // Prompt for name and comment.
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.Write("Enter your comment: ");
                string userComment = Console.ReadLine();

                // Add the comment to the video.
                selectedVideo.AddComment(userName, userComment);

                Console.WriteLine("Comment added!");

                // Redisplay the video with the new comment
                Console.WriteLine("Here's the video with the new comment:"); //Added message to indicate a redisplay of video
                selectedVideo.display();
                Console.WriteLine(new String('-', 30)); // Separator line

            }
            else
            {
                Console.WriteLine("Invalid video number.");
            }

            // Ask if the user wants to add another comment.
            Console.Write("Do you want to add another comment to any video? (y/n): ");
            addCommentResponse = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Okay, no more comments added.");
        Console.WriteLine("Program Completed.");
    }
}