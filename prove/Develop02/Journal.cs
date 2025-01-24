using System;

namespace classes{
    public class Journal
    {
        IDictionary<string, bool> prompts = new Dictionary<string, bool>();
        public void AddKeyValuePair()
        {
            prompts.Add("What is the best thing that happened today?", false);
            prompts.Add("What is the worst thing that happened this week?", false);
            prompts.Add("What am I grateful for today?", false);
            prompts.Add("What did I learn today?", false);
            prompts.Add("What is the most suprisong thing that happened today?", false);

        }

        public List<string> responses = new List<string>();

        public void ShowMenu()
        {
            Console.WriteLine("Welcome to your journal");
            Console.WriteLine("You have a whole 5 options to choose from:");
            Console.WriteLine("1. Write an entry!");
            Console.WriteLine("2. Display your journal and all its secrets.");
            Console.WriteLine("3. Save what you have.");
            Console.WriteLine("4. Load what youve written");
            Console.WriteLine("5. Or lock that journal up tight and leave.");
            Console.WriteLine("What would you like to do?");

            
        }

        public void DisplayEntry()
        {
            
            responses.ForEach(Console.WriteLine);
        }

        public void Write()
        {
            
            
            List<string> keys = new List<string>(prompts.Keys);
            List<string> unansweredQuestion = new List<string>(keys.Where(question => this.prompts[question] == false));
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            Random rndNum = new Random();
            int listSize = unansweredQuestion.Count;
            int rndIndex = rndNum.Next(0, listSize);
            if (unansweredQuestion.Count == 0)
            {
                Console.WriteLine("No more prompts available");
                return;
            }
            string index  = rndIndex.ToString();
            string randomQuestion = (unansweredQuestion[rndIndex]);
            
            prompts[randomQuestion] = true;
            Console.WriteLine(randomQuestion);
            

            string answer = Console.ReadLine();
            responses.Add($"Date: {date} - Prompt: {randomQuestion} - {answer}");

        }

        public Journal()
        {

        }      
                

    }  
}