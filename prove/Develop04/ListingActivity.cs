public class ListingActivity : Activity
{
    private List<string> _promptsList = new List<string>(); 
    public List<string> _responsesList =new List<string>();

    public ListingActivity(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)
    {   
        
        _promptsList.Add("Who are some people who bring you joy and positivity");
        _promptsList.Add("What are some strengths you are proud of, and what are areas you would like to improve?");
        _promptsList.Add("Have you had the chance to help someone this week?");
        _promptsList.Add("When was a moment this month that brought you happiness?");
        _promptsList.Add("Who are a few of your favorite people and what makes them so special to you?");
        
    
    }
    public void StartListingActivity(){
        StartActivity(_activityName, _description );
        Console.Clear();
        Console.WriteLine("Are you ready to begin this journey? Off we go!");
        InitialPause();
        Console.WriteLine("Take a moment to list as many responses as you can to the following prompt: ");
        Random random = new Random();
        int randomIndex = random.Next(_promptsList.Count);
        Console.WriteLine(_promptsList[randomIndex]);
        _promptsList.RemoveAt(randomIndex);
        InitialPause();
        Console.WriteLine("You can begin in:");
        Countdown(_initialPauseDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        

        while  (DateTime.Now < endTime){
            Console.Write(">");
            _responsesList.Add(Console.ReadLine());
        }
        int lenghtListedItems = _responsesList.Count;
        Console.WriteLine($"You listed {lenghtListedItems} items! Great job!");
        Console.WriteLine();
        DisplayEndingMessage(_activityName);
        

    }
    public void Countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i + "...");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}