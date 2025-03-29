using System;
using System.Collections.Generic;  // Import the namespace for List

class Comment
{
    protected string _name;
    protected string _comment;

    // Lists of names and comments to choose from.
    List<string> names = new List<string>{
        "Alice",
        "Bob",
        "Charlie",
        "David",
        "Eve",
        "Grace",
        "Henry",
        "Ivy",
        "Jack",
        "Kelly"
    };

    List<string> comments = new List<string>{
        "Great video! I learned a lot.",
        "This is amazing! Thanks for sharing.",
        "I love your content!",
        "Could you make a video about [topic]?",
        "This was really helpful.",
        "Awesome work!",
        "I'm looking forward to your next video.",
        "Excellent explanation.",
        "Very informative, thank you!",
        "Keep up the great work!"
    };

    // Constructor to create a random comment.
    public Comment()
    {
        Random random = new Random();
        _name = names[random.Next(names.Count)];
        _comment = comments[random.Next(comments.Count)];
    }
        // Constructor to create a specific comment.
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    // Method to display the comment.
    public void display()
    {
        Console.WriteLine($"{_name} says: \"{_comment}\"\n"); // Modified to include "says:"
    }
}