using System;
using System.Collections.Generic; // Import the namespace for List

class Video
{
    protected string _title;
    protected string _author;
    protected int _length;

    // Constructor for the Video class.
    public Video(string title, string author, int length)
    {
        // Error handling: Check if the length is valid.
        if (length <= 0)
        {
            Console.WriteLine("Error: Video length must be a positive number. Setting length to 60 seconds.");
            _length = 60; // Default value
        }
        else
        {
            _length = length;
        }

        _title = title;
        _author = author;
    }

    List<Comment> comments = new List<Comment>{
        new Comment(),
        new Comment(),
        new Comment()
    };

    // Method to get the number of comments.
    public int GetNumberComment()
    {
        return comments.Count;
    }

    // Method to display the video information and comments.
    public void display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {FormatDuration(_length)}"); // Use helper method
        Console.WriteLine($"Comments ({GetNumberComment()}):");

        if (comments.Count == 0)
        {
            Console.WriteLine("No comments yet.");
        }
        else
        {
            foreach (Comment comment in comments)
            {
                comment.display();
            }
        }
    }

    // Helper method to format the duration (seconds to HH:MM:SS)
    private string FormatDuration(int totalSeconds)
    {
        TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
        return time.ToString(@"hh\:mm\:ss");
    }
    // Method to add a new comment to the video
    public void AddComment(string name, string commentText)
    {
        Comment newComment = new Comment(name, commentText);
        comments.Add(newComment);
    }
}