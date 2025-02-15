using System;
using System.Collections.Generic;

public class WordHider
{
    public static string HideWords(string text, int wordsToHide)
    {
        // Split the text into words
        string[] words = text.Split(' ');
        Random rand = new Random();

        // Create a HashSet to track which words have been hidden
        HashSet<int> hiddenIndices = new HashSet<int>();

        while (hiddenIndices.Count < wordsToHide)
        {
            int index = rand.Next(words.Length);
            if (!hiddenIndices.Contains(index))
            {
                words[index] = new string('_', words[index].Length);
                hiddenIndices.Add(index);
            }
        }

        return string.Join(" ", words);
    }
}