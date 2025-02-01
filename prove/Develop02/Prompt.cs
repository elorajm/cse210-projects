using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> prompts;

    public Prompt()
    {
        prompts = new List<string>
        {
            "What was the best part of my day?",
            "What is somthing that made you laugh?",
            "What is the current problem or challange Im facing?",
            "Was I creative todaY? How?",
            "What are my top prioities today?",
            "What was a small detail I noticed today?",
            "What was the weather like today?",
            "How can I make tommorrow better?",
            "What did I learn today?",
            "How did I show gratitude today?",
            "What did I learn about myself today?",
            "If I could have a supper power what would it be and why?",
            "What is something quirky about myself?",
            
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}