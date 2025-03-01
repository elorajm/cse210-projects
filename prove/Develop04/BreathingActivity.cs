public class BreathingActivity : Activity{
    private int _breathInSeconds;
    private int _breatheOutSeconds;

    public BreathingActivity(int _duration, string _description, string _activityName, int _initialPauseDuration, int _finalPauseDuration, string _endingMessage, int breathIn, int breathOut) : base(_duration, _description, _activityName, _initialPauseDuration, _finalPauseDuration, _endingMessage)
    {
        _breatheOutSeconds = breathOut;
        _breathInSeconds = breathIn;
    }

    public void StartBreathingActivity(){
        StartActivity(_activityName, _description);

        int breathCount = _duration / (_breathInSeconds + _breatheOutSeconds);
        Console.Clear();
        Console.WriteLine("It is time to get ready and begin your mindful breathing journey! You are about to create a peaceful moment for yourself.");
        InitialPause();
        for (int i = 0; i < breathCount; i++){
            Console.WriteLine("Inhale... Breathe in deeply, filling your body with calm and positive energy.");
            Countdown(_breathInSeconds);
            Console.WriteLine("Exhale... Let go of any tension, releasing it with each breath.");
            Countdown(_breatheOutSeconds);

        }
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