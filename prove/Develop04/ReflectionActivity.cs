public class ReflectionActivity : Activity{
    private List<string> _promptsList = new List<string>(); 
    public List<string> _questionsList =new List<string>(){
        "Why was this experience so meaningful for you?",
        "Have you had a similar experience before?",
        "What inspired you to get started?",
        "How did you feel once you completed the activity?",
        "What made this time feel different from moments when you faced challenges before?",
        "What is your favorite part of this experience?",
        "What lessons from this experience can you apply to other areas of your life?",
        "What insights did you discover about yourself through this process?",
        "How can you carry the positive impact of this experience forward?"
    };

    public ReflectionActivity(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)
    {   
        
        _promptsList.Add("Reflect on a time when you supported someone who needed it.");
        _promptsList.Add("Remember a moment when you faced and overcame a difficult challenge.");
        _promptsList.Add("Think of a time when you offered a helping hand to someone in need.");
        _promptsList.Add("Recall a time when you acted with kindness and gave without expecting anything in return.");
        
    
    }
    public void StartReflectionActivity(){
        StartActivity(_activityName, _description );
        Console.Clear();
        Console.WriteLine("Excited to begin? Let's get started!");
        Console.WriteLine();
        InitialPause();
        Random random = new Random();
        int randomIndex = random.Next(_promptsList.Count);
        Console.WriteLine(_promptsList[randomIndex]);
        _promptsList.RemoveAt(randomIndex);
        InitialPause();
        Console.WriteLine();
        Console.WriteLine("When you're ready, press enter to move forward.");
        Console.ReadLine();
        Console.WriteLine("Take a moment to reflect on each of the following questions and how they relate to your experience.");
        Countdown(_initialPauseDuration);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while  (DateTime.Now < endTime){
            Random randomQuestion = new Random();
            int randomQuestionIndex = randomQuestion.Next(_questionsList.Count);
            Console.WriteLine("> " + _questionsList[randomQuestionIndex]);
            _questionsList.RemoveAt(randomQuestionIndex);
            InitialPause(20);
            Console.WriteLine();
        }
        Console.WriteLine("Great job! You did amazing!");
        InitialPause();
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
       